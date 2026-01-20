using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Good_Food_2016
{
    public static class Error
    {
        public static bool NumeOk(string nume)
        {
            if (!nume.All(char.IsLetter))
                return false;

            return true;
        }

        public static bool PrenumeOk(string prenume)
        {
            if (!prenume.All(char.IsLetter))
                return false;

            return true;
        }

        public static bool ParolaOk(string parola, string rparola)
        {
            if(parola != rparola)
                return false;

            return true;
        }

        public static bool EmailOk(string email)
        {
            int arond = 0;
            int punct = 0;

            bool arondFirst = true;

            foreach(char c in email)
            {
                if(c == '@')
                {
                    arond++;
                }

                if(c == '.')
                {
                    if(arond == 0)
                    {
                        arondFirst = false;
                    }

                    punct++;
                }
            }

            if (!arondFirst)
                return false;

            if ((arond > 1 || arond == 0) && (punct > 1 || punct == 0))
                return false;

            if (!DB.isEmailVacant(email))
                return false;

            return true;
        }

        public static bool AccountOk(string nume, string prenume, string adresa, string parola, string rparola, string email)
        {
            if (!Error.NumeOk(nume))
                return false;
            if (!Error.PrenumeOk(prenume))
                return false;
            if(!Error.ParolaOk(parola, rparola))
                return false;
            if(!Error.EmailOk(email))
                return false;

            return true;
        }

        public static bool AccountExist(string email, string parola)
        {
            bool ok = true;

            if (DB.isEmailVacant(email))
                return false;

            SqlDataReader reader = DB.OpenReader(String.Format("SELECT parola FROM Clienti WHERE email = '{0}';", email));

            reader.Read();

            if (reader[0].ToString() != parola)
                ok = false;

            DB.CloseReader(reader);

            return ok;
        }
    }
}
