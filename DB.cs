using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Good_Food_2016
{
    public static class DB
    {
        private static string path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GOOD_FOOD.mdf;Integrated Security=True;Connect Timeout=30";

        private static SqlConnection conn = new SqlConnection(path);
        private static SqlCommand cmd;
        private static SqlDataReader reader;
        private static SqlDataAdapter adapter;

        private static StreamReader stream;

        public static void NewCmd(string s)
        {
            conn.Open();

            cmd = new SqlCommand(s, conn);
        }

        public static void ExecuteCmd()
        {
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        
        public static SqlDataReader OpenReader(string s)
        {
            conn.Open();

            cmd = new SqlCommand(s, conn);

            reader = cmd.ExecuteReader();

            return reader;
        }

        public static void CloseReader(SqlDataReader readeru)
        {
            readeru.Close();
            reader.Close();

            conn.Close();
        }

        public static bool isEmailVacant(string s)
        {
            OpenReader(String.Format("SELECT * FROM Clienti WHERE email = '{0}';", s));

            bool ok = false;

            while(reader.Read())
            {
                ok = true;
            }

            CloseReader(reader);

            if (ok)
                return false;

            return true;
        }

        public static void NewClient(string nume, string prenume, string adresa, string parola, string rparola, string email, out bool ok)
        {
            ok = true;

            if(!Error.AccountOk(nume, prenume, adresa , parola, rparola, email))
            {
                MessageBox.Show("Input invalid!");
                ok = false;
            }
            else
            {
                DB.NewCmd(String.Format("INSERT INTO Clienti(parola, nume, prenume, adresa, email) VALUES(@parola, @nume, @prenume, @adresa, @email);"));

                cmd.Parameters.AddWithValue("@parola", parola);
                cmd.Parameters.AddWithValue("@nume", nume);
                cmd.Parameters.AddWithValue("@prenume", prenume);
                cmd.Parameters.AddWithValue("@adresa", adresa);
                cmd.Parameters.AddWithValue("@email", email);

                DB.ExecuteCmd();

                MessageBox.Show("Bine ati venit!");

                
            }
        }

        public static void UpdateKcal(string email, int kcal)
        {
            DB.NewCmd(String.Format("UPDATE Clienti SET kcal_zilnice = '{0}' WHERE email = '{1}';", kcal, email));

            DB.ExecuteCmd();
        }

        public static void InitDGVOpt(DataGridView dgv, string path)
        {
            DB.InitMeniu(path);

            DB.NewCmd("SELECT * FROM Meniu;");

            adapter = new SqlDataAdapter(cmd);

            DB.ExecuteCmd();

            DataTable dt = new DataTable();

            adapter.Fill(dt);  // din baza de date

            dgv.DataSource = dt;

            for (int i = 0; i < dgv.RowCount; i++)
            {
                dgv.Rows[i].Cells[6].Value = 1;
            }

            dgv.RowTemplate.Height = 50;
        }

        public static void InitDgvCmd(DataGridView dgv, string id_comanda)
        {
            dgv.Rows.Clear();

            reader = OpenReader(String.Format("SELECT * FROM Subcomenzi WHERE id_comanda = '{0}';", id_comanda));

            List<int> id = new List<int>();
            Dictionary<int, int> idcan = new Dictionary<int, int>();

            while(reader.Read())
            {
                id.Add(Convert.ToInt32(reader[2].ToString()));
                idcan[Convert.ToInt32(reader[2].ToString())] = Convert.ToInt32(reader[3].ToString()); ;
            }

            CloseReader(reader);

            foreach (int n in id)
            {
                string nume_produs;
                int kcal;
                int pret;
                int cantitate;

                reader = OpenReader(String.Format("SELECT denumire_produs, kcal, pret FROM Meniu WHERE id_produs = '{0}';", n));

                reader.Read();

                nume_produs = reader[0].ToString();
                kcal = Convert.ToInt32(reader[1].ToString());
                pret = Convert.ToInt32(reader[2].ToString());
                cantitate = idcan[n];

                CloseReader(reader);

                dgv.RowTemplate.Height = 50;
                dgv.Rows.Add(nume_produs, kcal, pret, cantitate);
            }

        }

        public static void InitMeniu(string path)
        {
            DB.NewCmd("DELETE FROM Meniu;");

            DB.ExecuteCmd();

            try
            {
                stream = new StreamReader(path);

                string linie = stream.ReadLine();

                do
                {
                    linie = stream.ReadLine();

                    if (linie != null)
                    {
                        string[] detalii = linie.Split(';');

                        DB.InsertMenuLine(Convert.ToInt32(detalii[0]), detalii[1], detalii[2], Convert.ToInt32(detalii[3]), Convert.ToInt32(detalii[4]), Convert.ToInt32(detalii[5]));

                    }

                } while (linie != null);

                stream.Close();
            }
            catch(Exception eee)
            { }
        }

        public static void InsertMenuLine(int id_produs, string denumire_produs, string descriere, int pret, int kcal, int felul)
        {

            DB.NewCmd(String.Format("INSERT INTO Meniu(id_produs, denumire_produs, descriere, pret, kcal, felul) VALUES(@id_produs, @denumire_produs, @descriere, @pret, @kcal, @felul);"));

            cmd.Parameters.Add("@id_produs", SqlDbType.Int);
            cmd.Parameters.Add("@denumire_produs", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@descriere", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@pret", SqlDbType.Int);
            cmd.Parameters.Add("@kcal", SqlDbType.Int);
            cmd.Parameters.Add("@felul", SqlDbType.Int);

            cmd.Parameters["@id_produs"].Value = id_produs;
            cmd.Parameters["@denumire_produs"].Value = denumire_produs;
            cmd.Parameters["@descriere"].Value = descriere;
            cmd.Parameters["@pret"].Value = pret;
            cmd.Parameters["@kcal"].Value = kcal;
            cmd.Parameters["@felul"].Value = felul;

            DB.ExecuteCmd();
        }

        public static void NewOrder(int idclient, DateTime dateTime)
        {
            int idc = 1;

            reader = OpenReader("SELECT * FROM Comenzi;");

            while(reader.Read())
            {
                idc++;
            }

            CloseReader(reader);

            NewCmd(String.Format("INSERT INTO Comenzi(id_comanda,id_client, data_comanda) VALUES(@idc, @idp, @data);"));

            cmd.Parameters.Add("@idc", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@idp", SqlDbType.Int);
            cmd.Parameters.Add("@data", SqlDbType.DateTime);

            cmd.Parameters["@idc"].Value = "" + idc;
            cmd.Parameters["@idp"].Value = idclient;
            cmd.Parameters["@data"].Value = dateTime;

            ExecuteCmd();
        }

        public static void NewProduct(string idcomanda, int idprodus, int cantitate)
        {
            NewCmd(String.Format("INSERT INTO Subcomenzi(id_comanda, id_produs, cantitate) VALUES(@idc, @idp, @can);"));

            cmd.Parameters.Add("@idc", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@idp", SqlDbType.Int);
            cmd.Parameters.Add("@can", SqlDbType.Int);

            cmd.Parameters["@idc"].Value = idcomanda;
            cmd.Parameters["@idp"].Value = idprodus;
            cmd.Parameters["@can"].Value = cantitate;

            ExecuteCmd();
        }

        public static bool ProductInCart(string idcomanda, int idprodus, int cantitate)
        {
            reader = OpenReader(String.Format("SELECT * FROM Subcomenzi WHERE id_comanda = '{0}' AND id_produs = '{1}';", idcomanda, idprodus));

            bool ok = false;

            int cant2 = 0;

            while(reader.Read())
            {
                ok = true;
                cant2 = Convert.ToInt32(reader[3].ToString());
            }

            CloseReader(reader);

            if(ok)
            {
                int cant = cantitate + cant2;

                NewCmd(String.Format("UPDATE Subcomenzi SET cantitate = '{0}' WHERE id_comanda = '{1}' AND id_produs = '{2}';", cant, idcomanda, idprodus));

                ExecuteCmd();

                return ok;
            }

            return ok;
        }

        public static int GetIdClient(string email)
        {
            reader = OpenReader(String.Format("SELECT id_client FROM Clienti WHERE email = '{0}';", email));

            reader.Read();

            int id = Convert.ToInt32(reader[0].ToString());

            CloseReader(reader);

            return id;
        }

        public static string GetIdOrder(DateTime date)
        {
            conn.Open();

            cmd = new SqlCommand(String.Format("SELECT id_comanda FROM Comenzi WHERE data_comanda = @date;"), conn);

            cmd.Parameters.Add("@date", SqlDbType.DateTime);

            cmd.Parameters["@date"].Value = date;

            reader = cmd.ExecuteReader();

            reader.Read();

            string id = reader[0].ToString();

            CloseReader(reader);

            return id;
        }

        public static int GetIdProduct(string name)
        {
            conn.Open();

            cmd = new SqlCommand(String.Format("SELECT id_produs FROM Meniu WHERE denumire_produs = @name;"), conn);

            cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50);

            cmd.Parameters["@name"].Value = name;

            reader = cmd.ExecuteReader();

            reader.Read();

            int id = Convert.ToInt32(reader[0].ToString());

            CloseReader(reader);

            return id;
        }

        public static void DeleteRowDgvCmd(DataGridView dgv, string idcomanda, string name)
        {
            int idprodus = GetIdProduct(name);

            NewCmd(String.Format("DELETE FROM Subcomenzi WHERE id_comanda = '{0}' AND id_produs = '{1}';", idcomanda, idprodus));

            ExecuteCmd();

            InitDgvCmd(dgv, idcomanda);
        }

        public static String GetMenuItemName(int idprodus)
        {
            reader = OpenReader(String.Format("SELECT denumire_produs FROM Meniu WHERE id_produs = '{0}';", idprodus));

            string nume;

            reader.Read();

            nume = reader[0].ToString();

            CloseReader(reader);

            return nume;
        }

        public static int GetMenuItemKcal(int idprodus)
        {
            reader = OpenReader(String.Format("SELECT kcal FROM Meniu WHERE id_produs = '{0}';", idprodus));

            int kcal;

            reader.Read();

            kcal = Convert.ToInt32(reader[0].ToString());

            CloseReader(reader);

            return kcal;
        }

        public static int GetMenuItemPret(int idprodus)
        {
            reader = OpenReader(String.Format("SELECT pret FROM Meniu WHERE id_produs = '{0}';", idprodus));

            int pret;

            reader.Read();

            pret = Convert.ToInt32(reader[0].ToString());

            CloseReader(reader);

            return pret;
        }

        public static void GenerateMenu(DataGridView dgv, int neckcal, int pret)
        {
            dgv.Rows.Clear();

            for(int i = 1; i <= 5; i++)
            {
                for(int j = 6; j <= 21; j++)
                {
                    for(int k = 22; k <= 27; k++)
                    {
                        int pret1, pret2, pret3;
                        int kcal1, kcal2, kcal3;

                        string nume1, nume2, nume3;

                        pret1 = GetMenuItemPret(i);
                        pret2 = GetMenuItemPret(j);
                        pret3 = GetMenuItemPret(k);

                        int totalpret = pret1 + pret2 + pret3;

                        if(totalpret > pret)
                        {
                            break;
                        }

                        kcal1 = GetMenuItemKcal(i);
                        kcal2 = GetMenuItemKcal(j);
                        kcal3 = GetMenuItemKcal(k);

                        int totalkcal = kcal1 + kcal2 + kcal3;

                        if(totalkcal > neckcal)
                        {
                            break;
                        }

                        nume1 = GetMenuItemName(i);
                        nume2 = GetMenuItemName(j);
                        nume3 = GetMenuItemName(k);

                        dgv.Rows.Add(nume1, nume2, nume3, totalkcal, totalpret);
                    }
                }
            }
        }
    }
}
