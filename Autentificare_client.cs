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
    public partial class Autentificare_client : Form
    {
        int ok = 1;

        public Autentificare_client()
        {
            InitializeComponent();
        }

        private void btnSeePass_Click(object sender, EventArgs e)
        {
            ok *= -1;

            if (ok == -1)
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

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if(Error.AccountExist(txtEmail.Text.ToString(), txtPass.Text.ToString()))
            {
                Optiuni op = new Optiuni(txtEmail.Text.ToString());

                Hide();
                op.Show();
            }
            else
            {
                MessageBox.Show("Eroare autentificare!");

                Reset();
            }
        }

        private void Reset()
        {
            txtPass.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Start st = new Start();

            Hide();
            st.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
