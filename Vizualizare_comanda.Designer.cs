namespace Good_Food_2016
{
    partial class Vizualizare_comanda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvCmd = new System.Windows.Forms.DataGridView();
            this.nume_produs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kcal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elimina = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gOOD_FOODDataSet = new Good_Food_2016.GOOD_FOODDataSet();
            this.subcomenziBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subcomenziTableAdapter = new Good_Food_2016.GOOD_FOODDataSetTableAdapters.SubcomenziTableAdapter();
            this.meniuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meniuTableAdapter = new Good_Food_2016.GOOD_FOODDataSetTableAdapters.MeniuTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNecKcal = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.txtTotKcal = new System.Windows.Forms.TextBox();
            this.btnFinalizare = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOOD_FOODDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcomenziBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meniuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(912, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.startToolStripMenuItem.Text = "back";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dgvCmd
            // 
            this.dgvCmd.AllowUserToAddRows = false;
            this.dgvCmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCmd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nume_produs,
            this.kcal,
            this.pret,
            this.cantitate,
            this.elimina});
            this.dgvCmd.Location = new System.Drawing.Point(0, 32);
            this.dgvCmd.Name = "dgvCmd";
            this.dgvCmd.ReadOnly = true;
            this.dgvCmd.RowHeadersWidth = 51;
            this.dgvCmd.RowTemplate.Height = 24;
            this.dgvCmd.Size = new System.Drawing.Size(912, 229);
            this.dgvCmd.TabIndex = 3;
            this.dgvCmd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCmd_CellContentClick);
            // 
            // nume_produs
            // 
            this.nume_produs.DataPropertyName = "denumire_produs";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.nume_produs.DefaultCellStyle = dataGridViewCellStyle5;
            this.nume_produs.HeaderText = "Nume produs";
            this.nume_produs.MinimumWidth = 6;
            this.nume_produs.Name = "nume_produs";
            this.nume_produs.ReadOnly = true;
            this.nume_produs.Width = 350;
            // 
            // kcal
            // 
            this.kcal.DataPropertyName = "kcal";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.kcal.DefaultCellStyle = dataGridViewCellStyle6;
            this.kcal.HeaderText = "Kcal";
            this.kcal.MinimumWidth = 6;
            this.kcal.Name = "kcal";
            this.kcal.ReadOnly = true;
            this.kcal.Width = 125;
            // 
            // pret
            // 
            this.pret.DataPropertyName = "pret";
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.pret.DefaultCellStyle = dataGridViewCellStyle7;
            this.pret.HeaderText = "Pret";
            this.pret.MinimumWidth = 6;
            this.pret.Name = "pret";
            this.pret.ReadOnly = true;
            this.pret.Width = 125;
            // 
            // cantitate
            // 
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.cantitate.DefaultCellStyle = dataGridViewCellStyle8;
            this.cantitate.HeaderText = "Cantitate";
            this.cantitate.MinimumWidth = 6;
            this.cantitate.Name = "cantitate";
            this.cantitate.ReadOnly = true;
            this.cantitate.Width = 125;
            // 
            // elimina
            // 
            this.elimina.HeaderText = "Elimina";
            this.elimina.MinimumWidth = 6;
            this.elimina.Name = "elimina";
            this.elimina.ReadOnly = true;
            this.elimina.Text = "Elimina";
            this.elimina.UseColumnTextForButtonValue = true;
            this.elimina.Width = 135;
            // 
            // gOOD_FOODDataSet
            // 
            this.gOOD_FOODDataSet.DataSetName = "GOOD_FOODDataSet";
            this.gOOD_FOODDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subcomenziBindingSource
            // 
            this.subcomenziBindingSource.DataMember = "Subcomenzi";
            this.subcomenziBindingSource.DataSource = this.gOOD_FOODDataSet;
            // 
            // subcomenziTableAdapter
            // 
            this.subcomenziTableAdapter.ClearBeforeFill = true;
            // 
            // meniuBindingSource
            // 
            this.meniuBindingSource.DataMember = "Meniu";
            this.meniuBindingSource.DataSource = this.gOOD_FOODDataSet;
            // 
            // meniuTableAdapter
            // 
            this.meniuTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Necesar kcal zilnice:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pret total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total kcal:";
            // 
            // txtNecKcal
            // 
            this.txtNecKcal.Enabled = false;
            this.txtNecKcal.Location = new System.Drawing.Point(341, 307);
            this.txtNecKcal.Name = "txtNecKcal";
            this.txtNecKcal.Size = new System.Drawing.Size(294, 36);
            this.txtNecKcal.TabIndex = 7;
            // 
            // txtPret
            // 
            this.txtPret.Enabled = false;
            this.txtPret.Location = new System.Drawing.Point(341, 420);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(294, 36);
            this.txtPret.TabIndex = 8;
            // 
            // txtTotKcal
            // 
            this.txtTotKcal.Enabled = false;
            this.txtTotKcal.Location = new System.Drawing.Point(341, 363);
            this.txtTotKcal.Name = "txtTotKcal";
            this.txtTotKcal.Size = new System.Drawing.Size(294, 36);
            this.txtTotKcal.TabIndex = 9;
            // 
            // btnFinalizare
            // 
            this.btnFinalizare.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFinalizare.ForeColor = System.Drawing.Color.White;
            this.btnFinalizare.Location = new System.Drawing.Point(274, 498);
            this.btnFinalizare.Name = "btnFinalizare";
            this.btnFinalizare.Size = new System.Drawing.Size(143, 51);
            this.btnFinalizare.TabIndex = 13;
            this.btnFinalizare.Text = "Finalizare";
            this.btnFinalizare.UseVisualStyleBackColor = false;
            this.btnFinalizare.Click += new System.EventHandler(this.btnFinalizare_Click);
            // 
            // Vizualizare_comanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(912, 570);
            this.Controls.Add(this.btnFinalizare);
            this.Controls.Add(this.txtTotKcal);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.txtNecKcal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCmd);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Vizualizare_comanda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vizualizare comanda";
            this.Load += new System.EventHandler(this.Vizualizare_comanda_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOOD_FOODDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcomenziBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meniuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvCmd;
        private GOOD_FOODDataSet gOOD_FOODDataSet;
        private System.Windows.Forms.BindingSource subcomenziBindingSource;
        private GOOD_FOODDataSetTableAdapters.SubcomenziTableAdapter subcomenziTableAdapter;
        private System.Windows.Forms.BindingSource meniuBindingSource;
        private GOOD_FOODDataSetTableAdapters.MeniuTableAdapter meniuTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNecKcal;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.TextBox txtTotKcal;
        private System.Windows.Forms.Button btnFinalizare;
        private System.Windows.Forms.DataGridViewTextBoxColumn nume_produs;
        private System.Windows.Forms.DataGridViewTextBoxColumn kcal;
        private System.Windows.Forms.DataGridViewTextBoxColumn pret;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitate;
        private System.Windows.Forms.DataGridViewButtonColumn elimina;
    }
}