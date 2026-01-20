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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Creare_cont_client ccc = new Creare_cont_client();

            Hide();
            ccc.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Autentificare_client ac = new Autentificare_client();

            Hide();
            ac.Show();
        }
    }
}
