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
    public partial class Vizualizare_comanda : Form
    {
        string email;

        int necKcal;
        int totKcal;
        int pretu;

        string idcomanda;

        public Vizualizare_comanda(string email, int necKcal, int totKcal, int pretu, string idcomanda)
        {
            InitializeComponent();
            this.email = email;

            this.necKcal = necKcal;
            this.totKcal = totKcal;
            this.pretu = pretu;
            this.idcomanda = idcomanda;

            DB.InitDgvCmd(dgvCmd, idcomanda);
        }

        private void Vizualizare_comanda_Load(object sender, EventArgs e)
        {
            txtNecKcal.Text = "" + necKcal;
            txtTotKcal.Text = "" + totKcal;
            txtPret.Text = "" + pretu;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Optiuni opt = new Optiuni(email);

            Hide();
            opt.Show();
        }

        private void btnFinalizare_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comanda trimisa!");

            Start st = new Start();

            Hide();
            st.Show();
        }

        private void dgvCmd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                string name = dgvCmd.Rows[e.RowIndex].Cells[0].Value.ToString();
                int kcal = Convert.ToInt32(dgvCmd.Rows[e.RowIndex].Cells[1].Value.ToString());
                int preturile = Convert.ToInt32(dgvCmd.Rows[e.RowIndex].Cells[2].Value.ToString());
                int cant = Convert.ToInt32(dgvCmd.Rows[e.RowIndex].Cells[3].Value.ToString());

                DB.DeleteRowDgvCmd(dgvCmd, idcomanda, name);

                totKcal -= (kcal * cant);
                pretu -= (preturile * cant);

                txtTotKcal.Text = "" + totKcal;
                txtPret.Text = "" + pretu;
            }
        }
    }
}
