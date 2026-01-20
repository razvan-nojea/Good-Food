using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Good_Food_2016
{
    public partial class Creare_cont_client : Form
    {
        int ok1 = 1;
        int ok2 = 1;

        public Creare_cont_client()
        {
            InitializeComponent();
        }

        private void btnSeePass_Click(object sender, EventArgs e)
        {
            ok1 *= -1;

            if(ok1==-1)
            {
                txtPass.PasswordChar = (char)0;

                btnSeePass.BackColor = Color.MidnightBlue;
            }
            else
            {
                txtPass.PasswordChar = '*';

                btnSeePass.BackColor = Color.SteelBlue;
            }
        }

        private void btnSeeRPass_Click(object sender, EventArgs e)
        {
            ok2 *= -1;

            if (ok2 == -1)
            {
                txtRPass.PasswordChar = (char)0;

                btnSeeRPass.BackColor = Color.MidnightBlue;
            }
            else
            {
                txtRPass.PasswordChar = '*';

                btnSeeRPass.BackColor = Color.SteelBlue;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Start st = new Start();

            Hide();
            st.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool ok;

            string nume = txtNume.Text.ToString();
            string prenume = txtPrenume.Text.ToString();
            string adresa = txtAdr.Text.ToString();
            string parola = txtPass.Text.ToString();
            string rparola = txtRPass.Text.ToString();
            string email = txtEmail.Text.ToString();

            DB.NewClient(nume, prenume, adresa, parola, rparola, email, out ok);

            if(ok)
            {
                Start st = new Start();

                Hide();
                st.Show();
            }
            else
            {
                Reset();
            }
        }

        private void Reset()
        {
            txtNume.Text = string.Empty;
            txtPrenume.Text = string.Empty;
            txtAdr.Text = string.Empty;
            txtPass.Text = string.Empty;
            txtRPass.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }
    }
}
