
namespace auto
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btn_recherche = new System.Windows.Forms.Button();
            this.btn_inserer = new System.Windows.Forms.Button();
            this.panel_insertion = new System.Windows.Forms.Panel();
            this.dgv_fichiers = new System.Windows.Forms.DataGridView();
            this.chemins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblnomprenom = new System.Windows.Forms.Label();
            this.lbldecision = new System.Windows.Forms.Label();
            this.lblauto = new System.Windows.Forms.Label();
            this.dtp_pv = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_typePermis = new System.Windows.Forms.ComboBox();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb__numDecision = new System.Windows.Forms.TextBox();
            this.tb_Reference = new System.Windows.Forms.TextBox();
            this.tb_NAutorisation = new System.Windows.Forms.TextBox();
            this.tb_NomPrenom = new System.Windows.Forms.TextBox();
            this.lbl_chemin = new System.Windows.Forms.Label();
            this.btn_parcourir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelpdf = new System.Windows.Forms.Panel();
            this.axAcroPDF2 = new AxAcroPDFLib.AxAcroPDF();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_menu.SuspendLayout();
            this.panel_insertion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fichiers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelpdf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF2)).BeginInit();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(0, 0);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(192, 192);
            this.axAcroPDF1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1397, 109);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1270, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana Pro Cond", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(413, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(680, 48);
            this.label12.TabIndex = 4;
            this.label12.Text = "gestion des autorisations urbanistique";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana Pro Cond", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(418, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(674, 48);
            this.label13.TabIndex = 5;
            this.label13.Text = "delivré par la commune de Oued-Zem";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 700);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1397, 33);
            this.panel2.TabIndex = 1;
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.panel_menu.Controls.Add(this.btn_recherche);
            this.panel_menu.Controls.Add(this.btn_inserer);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 109);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(200, 591);
            this.panel_menu.TabIndex = 2;
            // 
            // btn_recherche
            // 
            this.btn_recherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(136)))), ((int)(((byte)(170)))));
            this.btn_recherche.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_recherche.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(136)))), ((int)(((byte)(170)))));
            this.btn_recherche.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(170)))), ((int)(((byte)(206)))));
            this.btn_recherche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_recherche.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recherche.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_recherche.Image = ((System.Drawing.Image)(resources.GetObject("btn_recherche.Image")));
            this.btn_recherche.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_recherche.Location = new System.Drawing.Point(0, 47);
            this.btn_recherche.Name = "btn_recherche";
            this.btn_recherche.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_recherche.Size = new System.Drawing.Size(200, 47);
            this.btn_recherche.TabIndex = 1;
            this.btn_recherche.Text = "Rechecher";
            this.btn_recherche.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_recherche.UseVisualStyleBackColor = false;
            this.btn_recherche.Click += new System.EventHandler(this.btn_recherche_Click);
            // 
            // btn_inserer
            // 
            this.btn_inserer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(136)))), ((int)(((byte)(170)))));
            this.btn_inserer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_inserer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(136)))), ((int)(((byte)(170)))));
            this.btn_inserer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(170)))), ((int)(((byte)(206)))));
            this.btn_inserer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inserer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inserer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_inserer.Image = ((System.Drawing.Image)(resources.GetObject("btn_inserer.Image")));
            this.btn_inserer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_inserer.Location = new System.Drawing.Point(0, 0);
            this.btn_inserer.Name = "btn_inserer";
            this.btn_inserer.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_inserer.Size = new System.Drawing.Size(200, 47);
            this.btn_inserer.TabIndex = 0;
            this.btn_inserer.Text = "Insertion";
            this.btn_inserer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inserer.UseVisualStyleBackColor = false;
            this.btn_inserer.Click += new System.EventHandler(this.btn_inserer_Click);
            // 
            // panel_insertion
            // 
            this.panel_insertion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_insertion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.panel_insertion.Controls.Add(this.dgv_fichiers);
            this.panel_insertion.Controls.Add(this.groupBox1);
            this.panel_insertion.Controls.Add(this.lbl_chemin);
            this.panel_insertion.Controls.Add(this.btn_parcourir);
            this.panel_insertion.Controls.Add(this.label1);
            this.panel_insertion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_insertion.Location = new System.Drawing.Point(16, 0);
            this.panel_insertion.Margin = new System.Windows.Forms.Padding(0);
            this.panel_insertion.Name = "panel_insertion";
            this.panel_insertion.Size = new System.Drawing.Size(585, 591);
            this.panel_insertion.TabIndex = 5;
            // 
            // dgv_fichiers
            // 
            this.dgv_fichiers.AllowUserToAddRows = false;
            this.dgv_fichiers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            this.dgv_fichiers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_fichiers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_fichiers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_fichiers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_fichiers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_fichiers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_fichiers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fichiers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chemins});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_fichiers.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_fichiers.EnableHeadersVisualStyles = false;
            this.dgv_fichiers.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_fichiers.Location = new System.Drawing.Point(6, 43);
            this.dgv_fichiers.Name = "dgv_fichiers";
            this.dgv_fichiers.ReadOnly = true;
            this.dgv_fichiers.Size = new System.Drawing.Size(569, 260);
            this.dgv_fichiers.TabIndex = 5;
            this.dgv_fichiers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_fichiers_CellClick);
            // 
            // chemins
            // 
            this.chemins.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chemins.HeaderText = "Chemins des fichiers";
            this.chemins.Name = "chemins";
            this.chemins.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblnomprenom);
            this.groupBox1.Controls.Add(this.lbldecision);
            this.groupBox1.Controls.Add(this.lblauto);
            this.groupBox1.Controls.Add(this.dtp_pv);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cb_typePermis);
            this.groupBox1.Controls.Add(this.btn_ajouter);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb__numDecision);
            this.groupBox1.Controls.Add(this.tb_Reference);
            this.groupBox1.Controls.Add(this.tb_NAutorisation);
            this.groupBox1.Controls.Add(this.tb_NomPrenom);
            this.groupBox1.Location = new System.Drawing.Point(6, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 270);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saisie des données";
            // 
            // lblnomprenom
            // 
            this.lblnomprenom.AutoSize = true;
            this.lblnomprenom.Location = new System.Drawing.Point(553, 92);
            this.lblnomprenom.Name = "lblnomprenom";
            this.lblnomprenom.Size = new System.Drawing.Size(15, 19);
            this.lblnomprenom.TabIndex = 32;
            this.lblnomprenom.Text = "*";
            this.lblnomprenom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbldecision
            // 
            this.lbldecision.AutoSize = true;
            this.lbldecision.Location = new System.Drawing.Point(553, 61);
            this.lbldecision.Name = "lbldecision";
            this.lbldecision.Size = new System.Drawing.Size(15, 19);
            this.lbldecision.TabIndex = 31;
            this.lbldecision.Text = "*";
            this.lbldecision.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblauto
            // 
            this.lblauto.AutoSize = true;
            this.lblauto.Location = new System.Drawing.Point(552, 27);
            this.lblauto.Name = "lblauto";
            this.lblauto.Size = new System.Drawing.Size(15, 19);
            this.lblauto.TabIndex = 30;
            this.lblauto.Text = "*";
            this.lblauto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_pv
            // 
            this.dtp_pv.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dtp_pv.Location = new System.Drawing.Point(146, 195);
            this.dtp_pv.Name = "dtp_pv";
            this.dtp_pv.Size = new System.Drawing.Size(400, 25);
            this.dtp_pv.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "Type d\'autorisation :";
            // 
            // cb_typePermis
            // 
            this.cb_typePermis.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_typePermis.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_typePermis.FormattingEnabled = true;
            this.cb_typePermis.Items.AddRange(new object[] {
            "Permis de construire",
            "Permis d\'habiter",
            "Réception",
            "Réfection",
            "Régularisation",
            "Démolition"});
            this.cb_typePermis.Location = new System.Drawing.Point(145, 24);
            this.cb_typePermis.Name = "cb_typePermis";
            this.cb_typePermis.Size = new System.Drawing.Size(401, 25);
            this.cb_typePermis.TabIndex = 17;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(136)))), ((int)(((byte)(170)))));
            this.btn_ajouter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(150)))), ((int)(((byte)(195)))));
            this.btn_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajouter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ajouter.Location = new System.Drawing.Point(441, 226);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(105, 38);
            this.btn_ajouter.TabIndex = 23;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = false;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 19);
            this.label7.TabIndex = 29;
            this.label7.Text = "Date Autorisation :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "N°Décision :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "Référence foncières :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "N°Autorisation :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nom et Prenom :";
            // 
            // tb__numDecision
            // 
            this.tb__numDecision.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb__numDecision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb__numDecision.Location = new System.Drawing.Point(146, 55);
            this.tb__numDecision.Name = "tb__numDecision";
            this.tb__numDecision.Size = new System.Drawing.Size(401, 25);
            this.tb__numDecision.TabIndex = 18;
            // 
            // tb_Reference
            // 
            this.tb_Reference.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Reference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Reference.Location = new System.Drawing.Point(146, 164);
            this.tb_Reference.Name = "tb_Reference";
            this.tb_Reference.Size = new System.Drawing.Size(401, 25);
            this.tb_Reference.TabIndex = 21;
            // 
            // tb_NAutorisation
            // 
            this.tb_NAutorisation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_NAutorisation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_NAutorisation.Location = new System.Drawing.Point(146, 133);
            this.tb_NAutorisation.Name = "tb_NAutorisation";
            this.tb_NAutorisation.Size = new System.Drawing.Size(401, 25);
            this.tb_NAutorisation.TabIndex = 20;
            // 
            // tb_NomPrenom
            // 
            this.tb_NomPrenom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_NomPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_NomPrenom.Location = new System.Drawing.Point(146, 86);
            this.tb_NomPrenom.Name = "tb_NomPrenom";
            this.tb_NomPrenom.Size = new System.Drawing.Size(401, 25);
            this.tb_NomPrenom.TabIndex = 19;
            // 
            // lbl_chemin
            // 
            this.lbl_chemin.AutoSize = true;
            this.lbl_chemin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_chemin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chemin.Location = new System.Drawing.Point(100, 17);
            this.lbl_chemin.Name = "lbl_chemin";
            this.lbl_chemin.Size = new System.Drawing.Size(0, 19);
            this.lbl_chemin.TabIndex = 2;
            // 
            // btn_parcourir
            // 
            this.btn_parcourir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(136)))), ((int)(((byte)(170)))));
            this.btn_parcourir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(150)))), ((int)(((byte)(195)))));
            this.btn_parcourir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_parcourir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_parcourir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_parcourir.Location = new System.Drawing.Point(456, 12);
            this.btn_parcourir.Name = "btn_parcourir";
            this.btn_parcourir.Size = new System.Drawing.Size(119, 25);
            this.btn_parcourir.TabIndex = 1;
            this.btn_parcourir.Text = "parcourir ...";
            this.btn_parcourir.UseVisualStyleBackColor = false;
            this.btn_parcourir.Click += new System.EventHandler(this.btn_parcourir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Répertoire :";
            // 
            // panelpdf
            // 
            this.panelpdf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelpdf.Controls.Add(this.axAcroPDF2);
            this.panelpdf.Location = new System.Drawing.Point(617, 0);
            this.panelpdf.Margin = new System.Windows.Forms.Padding(0);
            this.panelpdf.Name = "panelpdf";
            this.panelpdf.Size = new System.Drawing.Size(580, 591);
            this.panelpdf.TabIndex = 6;
            // 
            // axAcroPDF2
            // 
            this.axAcroPDF2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axAcroPDF2.Enabled = true;
            this.axAcroPDF2.Location = new System.Drawing.Point(0, 0);
            this.axAcroPDF2.Name = "axAcroPDF2";
            this.axAcroPDF2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF2.OcxState")));
            this.axAcroPDF2.Size = new System.Drawing.Size(580, 591);
            this.axAcroPDF2.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.panel6.Location = new System.Drawing.Point(601, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(16, 591);
            this.panel6.TabIndex = 7;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.panel3);
            this.panelChildForm.Controls.Add(this.panel6);
            this.panelChildForm.Controls.Add(this.panelpdf);
            this.panelChildForm.Controls.Add(this.panel_insertion);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(200, 109);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1197, 591);
            this.panelChildForm.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(16, 591);
            this.panel3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1397, 733);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autorisation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_menu.ResumeLayout(false);
            this.panel_insertion.ResumeLayout(false);
            this.panel_insertion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fichiers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelpdf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF2)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button btn_recherche;
        private System.Windows.Forms.Button btn_inserer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel_insertion;
        private System.Windows.Forms.DataGridView dgv_fichiers;
        private System.Windows.Forms.DataGridViewTextBoxColumn chemins;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_pv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_typePermis;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb__numDecision;
        private System.Windows.Forms.TextBox tb_Reference;
        private System.Windows.Forms.TextBox tb_NAutorisation;
        private System.Windows.Forms.TextBox tb_NomPrenom;
        private System.Windows.Forms.Label lbl_chemin;
        private System.Windows.Forms.Button btn_parcourir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelpdf;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panel3;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblnomprenom;
        private System.Windows.Forms.Label lbldecision;
        private System.Windows.Forms.Label lblauto;
    }
}

