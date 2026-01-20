using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Good_Food_2016
{
    public partial class Optiuni : Form
    {
        int suma = 0;
        int calorii = 0;
        int neckcal;

        bool loaded = false;

        string idcomanda;

        DateTime currentcmdDate;

        string email;

        bool newcommand = false;

        string menu_path = AppDomain.CurrentDomain.BaseDirectory + @"resources\meniu.txt";

        public Optiuni(string emails)
        {
            InitializeComponent();

            email = emails;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int ani;
            int inalt;
            int greu;
            int kcal = 0;
            int s;

            if(txtAni.Text.Length == 0 || txtInalt.Text.Length == 0 || txtGreu.Text.Length == 0)
            {
                MessageBox.Show("Completeaza toate casutele!");
            }
            else
            {
                string anis = txtAni.Text.ToString();
                string inalts = txtInalt.Text.ToString();
                string greus = txtGreu.Text.ToString();

                if(int.TryParse(anis, out ani) && int.TryParse(inalts, out inalt) && int.TryParse(greus, out greu))
                {
                    s = ani + inalt + greu;

                    if(s < 250)
                        kcal = 1800;

                    if(s >= 250 && s <= 275)
                        kcal = 2200;

                    if (s > 275)
                        kcal = 2500;

                    txtNecesar.Text = "" + kcal;

                    DB.UpdateKcal(email, kcal);

                    neckcal = kcal;

                    RefreshKcal(neckcal);

                    txtNecesar.Show();
                    lblNec.Show();
                }
                else
                {
                    MessageBox.Show("Input invalid!");
                }
            }
        }

        private void txtAni_TextChanged(object sender, EventArgs e)
        {
            txtNecesar.Hide();
            lblNec.Hide();
        }

        private void txtInalt_TextChanged(object sender, EventArgs e)
        {
            txtNecesar.Hide();
            lblNec.Hide();
        }

        private void txtGreu_TextChanged(object sender, EventArgs e)
        {
            txtNecesar.Hide();
            lblNec.Hide();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Start st = new Start();

            Hide();
            st.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Optiuni_Load(object sender, EventArgs e)
        {
            DB.InitDGVOpt(dgv, menu_path);

            SqlDataReader reader;

            reader = DB.OpenReader(String.Format("SELECT kcal_zilnice FROM Clienti WHERE email = '{0}';", email));

            reader.Read();

            txtNecZil.Text = "" + reader[0];

            neckcal = Convert.ToInt32(reader[0].ToString());

            DB.CloseReader(reader);

            RefreshKcal(neckcal);

            loaded = true;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                int cantitate = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[6].Value);
                int pret = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[3].Value);
                int kcal = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[4].Value);
                int idprodus = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value);

                if (cantitate < 0)
                {
                    MessageBox.Show("Cantitate negativa!");
                }
                else
                {

                    int idclient = DB.GetIdClient(email);

                    if(!newcommand)
                    {
                        newcommand = true;

                        currentcmdDate = DateTime.Now;

                        DB.NewOrder(idclient, currentcmdDate);
                    }

                    idcomanda = DB.GetIdOrder(currentcmdDate);

                    if(!DB.ProductInCart(idcomanda, idprodus, cantitate))
                    {
                        DB.NewProduct(idcomanda, idprodus, cantitate);
                    }

                    suma += (pret * cantitate);
                    calorii += (kcal * cantitate);

                    UpdateOutput();
                }
            }
        }

        private void UpdateOutput()
        {
            txtTotKc.Text = "" + calorii;
            txtPretTot.Text = "" + suma;
        }

        private void dgv_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && loaded)
            {
                int n;

                if (!int.TryParse(dgv.Rows[e.RowIndex].Cells["cantitate_produs"].Value.ToString(), out n))
                {
                     MessageBox.Show("Valoare invalida!");
                }
            }
        }

        private void dgv_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["cantitate_produs"].Value = 1;
        }

        private void dgv_VisibleChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv.RowCount; i++)
            {
                dgv.Rows[i].Cells[6].Value = 1;
            }
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            Vizualizare_comanda viz = new Vizualizare_comanda(email, neckcal, calorii, suma, idcomanda);

            Hide();
            viz.Show();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int n;

            try
            {
                if(txtBuget.Text.Length > 0)
                {
                    if (int.TryParse(txtBuget.Text.ToString(), out n))
                    {
                        dgvGenMen.RowTemplate.Height = 50;
  
                        DB.GenerateMenu(dgvGenMen, neckcal, n);

                        dgvGenMen.RowTemplate.Height = 50;
                    }
                    else
                    {
                        MessageBox.Show("Valoare invalida!");
                    }
                }
                else
                {
                    MessageBox.Show("Introdu un buget!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Valoare invalida!");
            }
        }

        private void RefreshKcal(int kcal)
        {
            txtNecZil.Text = "" + kcal;
            txtNecGenMen.Text = "" + kcal;
        }

        private void dgvGenMen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                MessageBox.Show("Comanda trimisa!");

                int idclient = DB.GetIdClient(email);

                DateTime date = DateTime.Now;

                DB.NewOrder(idclient, date);

                string idcomanda = DB.GetIdOrder(date);

                for(int i = 0; i<3;i++)
                {
                    string productName = dgvGenMen.Rows[e.RowIndex].Cells[i].Value.ToString();

                    int idproduct = DB.GetIdProduct(productName);

                    DB.NewProduct(idcomanda, idproduct, 1);
                }

                Start st = new Start();

                Hide();
                st.Show();
            }
        }

        private void CreateChart(Chart chr)
        {

            chrKcal.Series["Produse"].Points.Clear();

            chrKcal.ChartAreas[0].AxisY.Maximum = 1000;

            int idclient = DB.GetIdClient(email);

            List<string> idcomenzi = new List<string>();
            List<int> idproducts = new List<int>();

            SqlDataReader reader = DB.OpenReader(String.Format("SELECT id_comanda FROM Comenzi WHERE id_client = '{0}';", idclient));

            while(reader.Read())
            {
                idcomenzi.Add(reader[0].ToString());
            }

            DB.CloseReader(reader);

            foreach(string s in idcomenzi)
            {
                reader = DB.OpenReader(String.Format("SELECT id_produs FROM Subcomenzi WHERE id_comanda = '{0}';", s));

                while(reader.Read())
                {
                    int idp = Convert.ToInt32(reader[0].ToString());

                    if(!idproducts.Contains(idp))
                    {
                        idproducts.Add(idp);
                    }
                }

                DB.CloseReader(reader);
            }

            foreach(int n in idproducts)
            {
                string name = DB.GetMenuItemName(n);
                int kcal = DB.GetMenuItemKcal(n);

                chrKcal.Series["Produse"].Points.AddXY(name, kcal);
            }

        }

        private void chrKcal_VisibleChanged(object sender, EventArgs e)
        {
            CreateChart(chrKcal);
        }
    }
}
