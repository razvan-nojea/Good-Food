namespace Good_Food_2016
{
    partial class Optiuni
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCalcKcal = new System.Windows.Forms.TabPage();
            this.txtNecesar = new System.Windows.Forms.TextBox();
            this.lblNec = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtGreu = new System.Windows.Forms.TextBox();
            this.txtInalt = new System.Windows.Forms.TextBox();
            this.txtAni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCmd = new System.Windows.Forms.TabPage();
            this.btnComanda = new System.Windows.Forms.Button();
            this.txtTotKc = new System.Windows.Forms.TextBox();
            this.txtPretTot = new System.Windows.Forms.TextBox();
            this.txtNecZil = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.idprodusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireprodusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kcalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.felulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitate_produs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adaugare = new System.Windows.Forms.DataGridViewButtonColumn();
            this.meniuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GOOD_FOODDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GOOD_FOODDataSet = new Good_Food_2016.GOOD_FOODDataSet();
            this.tabGenMen = new System.Windows.Forms.TabPage();
            this.tabGrfKcal = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meniuTableAdapter = new Good_Food_2016.GOOD_FOODDataSetTableAdapters.MeniuTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNecGenMen = new System.Windows.Forms.TextBox();
            this.txtBuget = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dgvGenMen = new System.Windows.Forms.DataGridView();
            this.felul1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.felul2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.felul3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalkcal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretMeniu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alege = new System.Windows.Forms.DataGridViewButtonColumn();
            this.chrKcal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabCalcKcal.SuspendLayout();
            this.tabCmd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meniuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GOOD_FOODDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GOOD_FOODDataSet)).BeginInit();
            this.tabGenMen.SuspendLayout();
            this.tabGrfKcal.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenMen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrKcal)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCalcKcal);
            this.tabControl1.Controls.Add(this.tabCmd);
            this.tabControl1.Controls.Add(this.tabGenMen);
            this.tabControl1.Controls.Add(this.tabGrfKcal);
            this.tabControl1.Location = new System.Drawing.Point(12, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1095, 546);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCalcKcal
            // 
            this.tabCalcKcal.Controls.Add(this.txtNecesar);
            this.tabCalcKcal.Controls.Add(this.lblNec);
            this.tabCalcKcal.Controls.Add(this.btnCalc);
            this.tabCalcKcal.Controls.Add(this.txtGreu);
            this.tabCalcKcal.Controls.Add(this.txtInalt);
            this.tabCalcKcal.Controls.Add(this.txtAni);
            this.tabCalcKcal.Controls.Add(this.label3);
            this.tabCalcKcal.Controls.Add(this.label2);
            this.tabCalcKcal.Controls.Add(this.label1);
            this.tabCalcKcal.Location = new System.Drawing.Point(4, 37);
            this.tabCalcKcal.Name = "tabCalcKcal";
            this.tabCalcKcal.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalcKcal.Size = new System.Drawing.Size(1087, 505);
            this.tabCalcKcal.TabIndex = 0;
            this.tabCalcKcal.Text = "CalculatorKcal";
            this.tabCalcKcal.UseVisualStyleBackColor = true;
            // 
            // txtNecesar
            // 
            this.txtNecesar.Location = new System.Drawing.Point(404, 104);
            this.txtNecesar.Name = "txtNecesar";
            this.txtNecesar.ReadOnly = true;
            this.txtNecesar.Size = new System.Drawing.Size(162, 37);
            this.txtNecesar.TabIndex = 13;
            this.txtNecesar.Visible = false;
            // 
            // lblNec
            // 
            this.lblNec.AutoSize = true;
            this.lblNec.ForeColor = System.Drawing.Color.Black;
            this.lblNec.Location = new System.Drawing.Point(412, 61);
            this.lblNec.Name = "lblNec";
            this.lblNec.Size = new System.Drawing.Size(182, 28);
            this.lblNec.TabIndex = 12;
            this.lblNec.Text = "Necesar zilnic:";
            this.lblNec.Visible = false;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalc.ForeColor = System.Drawing.Color.White;
            this.btnCalc.Location = new System.Drawing.Point(130, 262);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(143, 51);
            this.btnCalc.TabIndex = 11;
            this.btnCalc.Text = "Calculeaza";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtGreu
            // 
            this.txtGreu.Location = new System.Drawing.Point(197, 166);
            this.txtGreu.Name = "txtGreu";
            this.txtGreu.Size = new System.Drawing.Size(150, 37);
            this.txtGreu.TabIndex = 5;
            this.txtGreu.TextChanged += new System.EventHandler(this.txtGreu_TextChanged);
            // 
            // txtInalt
            // 
            this.txtInalt.Location = new System.Drawing.Point(197, 104);
            this.txtInalt.Name = "txtInalt";
            this.txtInalt.Size = new System.Drawing.Size(150, 37);
            this.txtInalt.TabIndex = 4;
            this.txtInalt.TextChanged += new System.EventHandler(this.txtInalt_TextChanged);
            // 
            // txtAni
            // 
            this.txtAni.Location = new System.Drawing.Point(197, 38);
            this.txtAni.Name = "txtAni";
            this.txtAni.Size = new System.Drawing.Size(150, 37);
            this.txtAni.TabIndex = 3;
            this.txtAni.TextChanged += new System.EventHandler(this.txtAni_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Greutate (kg)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inaltime (cm)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Varsta (ani)";
            // 
            // tabCmd
            // 
            this.tabCmd.Controls.Add(this.btnComanda);
            this.tabCmd.Controls.Add(this.txtTotKc);
            this.tabCmd.Controls.Add(this.txtPretTot);
            this.tabCmd.Controls.Add(this.txtNecZil);
            this.tabCmd.Controls.Add(this.label6);
            this.tabCmd.Controls.Add(this.label5);
            this.tabCmd.Controls.Add(this.label4);
            this.tabCmd.Controls.Add(this.dgv);
            this.tabCmd.Location = new System.Drawing.Point(4, 37);
            this.tabCmd.Name = "tabCmd";
            this.tabCmd.Padding = new System.Windows.Forms.Padding(3);
            this.tabCmd.Size = new System.Drawing.Size(1087, 505);
            this.tabCmd.TabIndex = 1;
            this.tabCmd.Text = "Comanda";
            this.tabCmd.UseVisualStyleBackColor = true;
            // 
            // btnComanda
            // 
            this.btnComanda.BackColor = System.Drawing.Color.SteelBlue;
            this.btnComanda.ForeColor = System.Drawing.Color.White;
            this.btnComanda.Location = new System.Drawing.Point(629, 402);
            this.btnComanda.Name = "btnComanda";
            this.btnComanda.Size = new System.Drawing.Size(143, 51);
            this.btnComanda.TabIndex = 12;
            this.btnComanda.Text = "Comanda";
            this.btnComanda.UseVisualStyleBackColor = false;
            this.btnComanda.Click += new System.EventHandler(this.btnComanda_Click);
            // 
            // txtTotKc
            // 
            this.txtTotKc.Enabled = false;
            this.txtTotKc.Location = new System.Drawing.Point(246, 413);
            this.txtTotKc.Name = "txtTotKc";
            this.txtTotKc.ReadOnly = true;
            this.txtTotKc.Size = new System.Drawing.Size(203, 37);
            this.txtTotKc.TabIndex = 6;
            // 
            // txtPretTot
            // 
            this.txtPretTot.Enabled = false;
            this.txtPretTot.Location = new System.Drawing.Point(246, 455);
            this.txtPretTot.Name = "txtPretTot";
            this.txtPretTot.ReadOnly = true;
            this.txtPretTot.Size = new System.Drawing.Size(203, 37);
            this.txtPretTot.TabIndex = 5;
            // 
            // txtNecZil
            // 
            this.txtNecZil.Enabled = false;
            this.txtNecZil.Location = new System.Drawing.Point(246, 372);
            this.txtNecZil.Name = "txtNecZil";
            this.txtNecZil.ReadOnly = true;
            this.txtNecZil.Size = new System.Drawing.Size(203, 37);
            this.txtNecZil.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(92, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 28);
            this.label6.TabIndex = 3;
            this.label6.Text = "Pret Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(92, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total Kcal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(92, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Necesar zilnic";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprodusDataGridViewTextBoxColumn,
            this.denumireprodusDataGridViewTextBoxColumn,
            this.descriereDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.kcalDataGridViewTextBoxColumn,
            this.felulDataGridViewTextBoxColumn,
            this.cantitate_produs,
            this.adaugare});
            this.dgv.DataSource = this.meniuBindingSource;
            this.dgv.Location = new System.Drawing.Point(6, 6);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.Size = new System.Drawing.Size(1075, 340);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellLeave);
            this.dgv.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgv_DefaultValuesNeeded);
            this.dgv.VisibleChanged += new System.EventHandler(this.dgv_VisibleChanged);
            // 
            // idprodusDataGridViewTextBoxColumn
            // 
            this.idprodusDataGridViewTextBoxColumn.DataPropertyName = "id_produs";
            this.idprodusDataGridViewTextBoxColumn.HeaderText = "Id produs";
            this.idprodusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idprodusDataGridViewTextBoxColumn.Name = "idprodusDataGridViewTextBoxColumn";
            this.idprodusDataGridViewTextBoxColumn.ReadOnly = true;
            this.idprodusDataGridViewTextBoxColumn.Width = 75;
            // 
            // denumireprodusDataGridViewTextBoxColumn
            // 
            this.denumireprodusDataGridViewTextBoxColumn.DataPropertyName = "denumire_produs";
            this.denumireprodusDataGridViewTextBoxColumn.HeaderText = "Denumire produs";
            this.denumireprodusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.denumireprodusDataGridViewTextBoxColumn.Name = "denumireprodusDataGridViewTextBoxColumn";
            this.denumireprodusDataGridViewTextBoxColumn.ReadOnly = true;
            this.denumireprodusDataGridViewTextBoxColumn.Width = 185;
            // 
            // descriereDataGridViewTextBoxColumn
            // 
            this.descriereDataGridViewTextBoxColumn.DataPropertyName = "descriere";
            this.descriereDataGridViewTextBoxColumn.HeaderText = "Descriere";
            this.descriereDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriereDataGridViewTextBoxColumn.Name = "descriereDataGridViewTextBoxColumn";
            this.descriereDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriereDataGridViewTextBoxColumn.Width = 272;
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            this.pretDataGridViewTextBoxColumn.ReadOnly = true;
            this.pretDataGridViewTextBoxColumn.Width = 125;
            // 
            // kcalDataGridViewTextBoxColumn
            // 
            this.kcalDataGridViewTextBoxColumn.DataPropertyName = "kcal";
            this.kcalDataGridViewTextBoxColumn.HeaderText = "Kcal";
            this.kcalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kcalDataGridViewTextBoxColumn.Name = "kcalDataGridViewTextBoxColumn";
            this.kcalDataGridViewTextBoxColumn.ReadOnly = true;
            this.kcalDataGridViewTextBoxColumn.Width = 125;
            // 
            // felulDataGridViewTextBoxColumn
            // 
            this.felulDataGridViewTextBoxColumn.DataPropertyName = "felul";
            this.felulDataGridViewTextBoxColumn.HeaderText = "Felul";
            this.felulDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.felulDataGridViewTextBoxColumn.Name = "felulDataGridViewTextBoxColumn";
            this.felulDataGridViewTextBoxColumn.ReadOnly = true;
            this.felulDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantitate_produs
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "0";
            this.cantitate_produs.DefaultCellStyle = dataGridViewCellStyle1;
            this.cantitate_produs.HeaderText = "Cantitate";
            this.cantitate_produs.MinimumWidth = 6;
            this.cantitate_produs.Name = "cantitate_produs";
            this.cantitate_produs.Width = 125;
            // 
            // adaugare
            // 
            this.adaugare.HeaderText = "Adaugare";
            this.adaugare.MinimumWidth = 6;
            this.adaugare.Name = "adaugare";
            this.adaugare.Text = "Adaugare";
            this.adaugare.UseColumnTextForButtonValue = true;
            this.adaugare.Width = 125;
            // 
            // meniuBindingSource
            // 
            this.meniuBindingSource.DataMember = "Meniu";
            this.meniuBindingSource.DataSource = this.GOOD_FOODDataSetBindingSource;
            // 
            // GOOD_FOODDataSetBindingSource
            // 
            this.GOOD_FOODDataSetBindingSource.DataSource = this.GOOD_FOODDataSet;
            this.GOOD_FOODDataSetBindingSource.Position = 0;
            // 
            // GOOD_FOODDataSet
            // 
            this.GOOD_FOODDataSet.DataSetName = "GOOD_FOODDataSet";
            this.GOOD_FOODDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabGenMen
            // 
            this.tabGenMen.Controls.Add(this.dgvGenMen);
            this.tabGenMen.Controls.Add(this.btnGenerate);
            this.tabGenMen.Controls.Add(this.txtBuget);
            this.tabGenMen.Controls.Add(this.txtNecGenMen);
            this.tabGenMen.Controls.Add(this.label8);
            this.tabGenMen.Controls.Add(this.label7);
            this.tabGenMen.Location = new System.Drawing.Point(4, 37);
            this.tabGenMen.Name = "tabGenMen";
            this.tabGenMen.Size = new System.Drawing.Size(1087, 505);
            this.tabGenMen.TabIndex = 2;
            this.tabGenMen.Text = "Generare Meniu";
            this.tabGenMen.UseVisualStyleBackColor = true;
            // 
            // tabGrfKcal
            // 
            this.tabGrfKcal.Controls.Add(this.chrKcal);
            this.tabGrfKcal.Location = new System.Drawing.Point(4, 37);
            this.tabGrfKcal.Name = "tabGrfKcal";
            this.tabGrfKcal.Size = new System.Drawing.Size(1087, 505);
            this.tabGrfKcal.TabIndex = 3;
            this.tabGrfKcal.Text = "Grafic Kcal";
            this.tabGrfKcal.UseVisualStyleBackColor = true;
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
            this.menuStrip1.Size = new System.Drawing.Size(1119, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.startToolStripMenuItem.Text = "start";
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
            // meniuTableAdapter
            // 
            this.meniuTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(298, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Necesarul zilnic de kcal:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(131, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 28);
            this.label8.TabIndex = 1;
            this.label8.Text = "Buget:";
            // 
            // txtNecGenMen
            // 
            this.txtNecGenMen.Enabled = false;
            this.txtNecGenMen.Location = new System.Drawing.Point(397, 43);
            this.txtNecGenMen.Name = "txtNecGenMen";
            this.txtNecGenMen.Size = new System.Drawing.Size(318, 37);
            this.txtNecGenMen.TabIndex = 2;
            // 
            // txtBuget
            // 
            this.txtBuget.Location = new System.Drawing.Point(397, 97);
            this.txtBuget.Name = "txtBuget";
            this.txtBuget.Size = new System.Drawing.Size(318, 37);
            this.txtBuget.TabIndex = 3;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(844, 59);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(169, 51);
            this.btnGenerate.TabIndex = 13;
            this.btnGenerate.Text = "Genereaza";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // dgvGenMen
            // 
            this.dgvGenMen.AllowUserToAddRows = false;
            this.dgvGenMen.AllowUserToDeleteRows = false;
            this.dgvGenMen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenMen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.felul1,
            this.felul2,
            this.felul3,
            this.totalkcal,
            this.pretMeniu,
            this.alege});
            this.dgvGenMen.Location = new System.Drawing.Point(3, 152);
            this.dgvGenMen.Name = "dgvGenMen";
            this.dgvGenMen.ReadOnly = true;
            this.dgvGenMen.RowHeadersWidth = 51;
            this.dgvGenMen.RowTemplate.Height = 24;
            this.dgvGenMen.Size = new System.Drawing.Size(1084, 350);
            this.dgvGenMen.TabIndex = 14;
            this.dgvGenMen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGenMen_CellContentClick);
            // 
            // felul1
            // 
            this.felul1.HeaderText = "Felul 1";
            this.felul1.MinimumWidth = 6;
            this.felul1.Name = "felul1";
            this.felul1.ReadOnly = true;
            this.felul1.Width = 220;
            // 
            // felul2
            // 
            this.felul2.HeaderText = "Felul 2";
            this.felul2.MinimumWidth = 6;
            this.felul2.Name = "felul2";
            this.felul2.ReadOnly = true;
            this.felul2.Width = 220;
            // 
            // felul3
            // 
            this.felul3.HeaderText = "Felul 3";
            this.felul3.MinimumWidth = 6;
            this.felul3.Name = "felul3";
            this.felul3.ReadOnly = true;
            this.felul3.Width = 220;
            // 
            // totalkcal
            // 
            this.totalkcal.HeaderText = "Total kcal";
            this.totalkcal.MinimumWidth = 6;
            this.totalkcal.Name = "totalkcal";
            this.totalkcal.ReadOnly = true;
            this.totalkcal.Width = 125;
            // 
            // pretMeniu
            // 
            this.pretMeniu.HeaderText = "Pret";
            this.pretMeniu.MinimumWidth = 6;
            this.pretMeniu.Name = "pretMeniu";
            this.pretMeniu.ReadOnly = true;
            this.pretMeniu.Width = 125;
            // 
            // alege
            // 
            this.alege.HeaderText = "Alege";
            this.alege.MinimumWidth = 6;
            this.alege.Name = "alege";
            this.alege.ReadOnly = true;
            this.alege.Text = "Alege";
            this.alege.UseColumnTextForButtonValue = true;
            this.alege.Width = 125;
            // 
            // chrKcal
            // 
            chartArea1.Name = "ChartArea1";
            this.chrKcal.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chrKcal.Legends.Add(legend1);
            this.chrKcal.Location = new System.Drawing.Point(0, 6);
            this.chrKcal.Name = "chrKcal";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Produse";
            this.chrKcal.Series.Add(series1);
            this.chrKcal.Size = new System.Drawing.Size(1074, 499);
            this.chrKcal.TabIndex = 0;
            this.chrKcal.Text = "chrKcal";
            this.chrKcal.VisibleChanged += new System.EventHandler(this.chrKcal_VisibleChanged);
            // 
            // Optiuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1119, 597);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Optiuni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optiuni";
            this.Load += new System.EventHandler(this.Optiuni_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCalcKcal.ResumeLayout(false);
            this.tabCalcKcal.PerformLayout();
            this.tabCmd.ResumeLayout(false);
            this.tabCmd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meniuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GOOD_FOODDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GOOD_FOODDataSet)).EndInit();
            this.tabGenMen.ResumeLayout(false);
            this.tabGenMen.PerformLayout();
            this.tabGrfKcal.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenMen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrKcal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCalcKcal;
        private System.Windows.Forms.TabPage tabCmd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabPage tabGenMen;
        private System.Windows.Forms.TabPage tabGrfKcal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGreu;
        private System.Windows.Forms.TextBox txtInalt;
        private System.Windows.Forms.TextBox txtAni;
        private System.Windows.Forms.TextBox txtNecesar;
        private System.Windows.Forms.Label lblNec;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.BindingSource GOOD_FOODDataSetBindingSource;
        private GOOD_FOODDataSet GOOD_FOODDataSet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnComanda;
        private System.Windows.Forms.TextBox txtTotKc;
        private System.Windows.Forms.TextBox txtPretTot;
        private System.Windows.Forms.TextBox txtNecZil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource meniuBindingSource;
        private GOOD_FOODDataSetTableAdapters.MeniuTableAdapter meniuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireprodusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kcalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn felulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitate_produs;
        private System.Windows.Forms.DataGridViewButtonColumn adaugare;
        private System.Windows.Forms.TextBox txtBuget;
        private System.Windows.Forms.TextBox txtNecGenMen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvGenMen;
        private System.Windows.Forms.DataGridViewTextBoxColumn felul1;
        private System.Windows.Forms.DataGridViewTextBoxColumn felul2;
        private System.Windows.Forms.DataGridViewTextBoxColumn felul3;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalkcal;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretMeniu;
        private System.Windows.Forms.DataGridViewButtonColumn alege;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrKcal;
    }
}