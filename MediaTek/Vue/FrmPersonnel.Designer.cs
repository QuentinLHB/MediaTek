namespace MediaTek.Vue
{
    partial class FrmPersonnel
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
            this.tlpGeneralLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tlpContenu = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lstPersonnel = new System.Windows.Forms.ListBox();
            this.lblTitreChoix = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.pnlOKButtons = new System.Windows.Forms.Panel();
            this.btnOKEdit = new System.Windows.Forms.Button();
            this.btnOKAjout = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAbsences = new System.Windows.Forms.Button();
            this.tblSaisie = new System.Windows.Forms.TableLayoutPanel();
            this.cboServices = new System.Windows.Forms.ComboBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.personnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tlpGeneralLayout.SuspendLayout();
            this.tlpContenu.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlOKButtons.SuspendLayout();
            this.tblSaisie.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpGeneralLayout
            // 
            this.tlpGeneralLayout.ColumnCount = 3;
            this.tlpGeneralLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.453876F));
            this.tlpGeneralLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.09225F));
            this.tlpGeneralLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.453875F));
            this.tlpGeneralLayout.Controls.Add(this.tlpContenu, 1, 2);
            this.tlpGeneralLayout.Controls.Add(this.panel1, 0, 0);
            this.tlpGeneralLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGeneralLayout.Location = new System.Drawing.Point(0, 0);
            this.tlpGeneralLayout.Name = "tlpGeneralLayout";
            this.tlpGeneralLayout.RowCount = 4;
            this.tlpGeneralLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.60544F));
            this.tlpGeneralLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tlpGeneralLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.02722F));
            this.tlpGeneralLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.60544F));
            this.tlpGeneralLayout.Size = new System.Drawing.Size(1082, 753);
            this.tlpGeneralLayout.TabIndex = 0;
            // 
            // tlpContenu
            // 
            this.tlpContenu.ColumnCount = 5;
            this.tlpContenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.09031F));
            this.tlpContenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.90612F));
            this.tlpContenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.715806F));
            this.tlpContenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tlpContenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.28776F));
            this.tlpContenu.Controls.Add(this.label1, 0, 0);
            this.tlpContenu.Controls.Add(this.lstPersonnel, 0, 1);
            this.tlpContenu.Controls.Add(this.lblTitreChoix, 3, 0);
            this.tlpContenu.Controls.Add(this.label3, 3, 2);
            this.tlpContenu.Controls.Add(this.label4, 3, 3);
            this.tlpContenu.Controls.Add(this.label5, 3, 4);
            this.tlpContenu.Controls.Add(this.label6, 3, 5);
            this.tlpContenu.Controls.Add(this.tableLayoutPanel2, 4, 6);
            this.tlpContenu.Controls.Add(this.btnAjouter, 1, 2);
            this.tlpContenu.Controls.Add(this.btnModifier, 1, 3);
            this.tlpContenu.Controls.Add(this.btnSupprimer, 1, 4);
            this.tlpContenu.Controls.Add(this.btnAbsences, 1, 5);
            this.tlpContenu.Controls.Add(this.tblSaisie, 4, 1);
            this.tlpContenu.Controls.Add(this.label2, 3, 1);
            this.tlpContenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenu.Location = new System.Drawing.Point(72, 140);
            this.tlpContenu.Name = "tlpContenu";
            this.tlpContenu.RowCount = 7;
            this.tlpContenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpContenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpContenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpContenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpContenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpContenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpContenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpContenu.Size = new System.Drawing.Size(936, 506);
            this.tlpContenu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste du personnel";
            // 
            // lstPersonnel
            // 
            this.lstPersonnel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.lstPersonnel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPersonnel.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lstPersonnel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstPersonnel.FormattingEnabled = true;
            this.lstPersonnel.ItemHeight = 21;
            this.lstPersonnel.Location = new System.Drawing.Point(3, 28);
            this.lstPersonnel.Name = "lstPersonnel";
            this.tlpContenu.SetRowSpan(this.lstPersonnel, 6);
            this.lstPersonnel.Size = new System.Drawing.Size(370, 475);
            this.lstPersonnel.TabIndex = 1;
            this.lstPersonnel.DoubleClick += new System.EventHandler(this.lstPersonnel_DoubleClick);
            this.lstPersonnel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstPersonnel_KeyUp);
            // 
            // lblTitreChoix
            // 
            this.lblTitreChoix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitreChoix.AutoSize = true;
            this.tlpContenu.SetColumnSpan(this.lblTitreChoix, 2);
            this.lblTitreChoix.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblTitreChoix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTitreChoix.Location = new System.Drawing.Point(742, 0);
            this.lblTitreChoix.Name = "lblTitreChoix";
            this.lblTitreChoix.Size = new System.Drawing.Size(70, 25);
            this.lblTitreChoix.TabIndex = 13;
            this.lblTitreChoix.Text = "Modifier";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(622, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nom :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(622, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Prénom :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(622, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tel. :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(622, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Mail :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(622, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Service : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnAnnuler, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pnlOKButtons, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(704, 428);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(229, 75);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.btnAnnuler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnAnnuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btnAnnuler.Location = new System.Drawing.Point(117, 3);
            this.btnAnnuler.MinimumSize = new System.Drawing.Size(74, 38);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(109, 69);
            this.btnAnnuler.TabIndex = 0;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // pnlOKButtons
            // 
            this.pnlOKButtons.Controls.Add(this.btnOKEdit);
            this.pnlOKButtons.Controls.Add(this.btnOKAjout);
            this.pnlOKButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOKButtons.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.pnlOKButtons.Location = new System.Drawing.Point(3, 3);
            this.pnlOKButtons.Name = "pnlOKButtons";
            this.pnlOKButtons.Size = new System.Drawing.Size(108, 69);
            this.pnlOKButtons.TabIndex = 2;
            // 
            // btnOKEdit
            // 
            this.btnOKEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.btnOKEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOKEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOKEdit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnOKEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btnOKEdit.Location = new System.Drawing.Point(0, 0);
            this.btnOKEdit.MinimumSize = new System.Drawing.Size(74, 38);
            this.btnOKEdit.Name = "btnOKEdit";
            this.btnOKEdit.Size = new System.Drawing.Size(108, 69);
            this.btnOKEdit.TabIndex = 0;
            this.btnOKEdit.Text = "OK";
            this.btnOKEdit.UseVisualStyleBackColor = false;
            this.btnOKEdit.Click += new System.EventHandler(this.btnOKEdit_Click);
            // 
            // btnOKAjout
            // 
            this.btnOKAjout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.btnOKAjout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOKAjout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOKAjout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.btnOKAjout.Location = new System.Drawing.Point(0, 0);
            this.btnOKAjout.MinimumSize = new System.Drawing.Size(74, 38);
            this.btnOKAjout.Name = "btnOKAjout";
            this.btnOKAjout.Size = new System.Drawing.Size(108, 69);
            this.btnOKAjout.TabIndex = 1;
            this.btnOKAjout.Text = "OK";
            this.btnOKAjout.UseVisualStyleBackColor = false;
            this.btnOKAjout.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnAjouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btnAjouter.Location = new System.Drawing.Point(379, 130);
            this.btnAjouter.MinimumSize = new System.Drawing.Size(94, 30);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(172, 30);
            this.btnAjouter.TabIndex = 26;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnModifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btnModifier.Location = new System.Drawing.Point(379, 210);
            this.btnModifier.MinimumSize = new System.Drawing.Size(94, 30);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(172, 30);
            this.btnModifier.TabIndex = 28;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnSupprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btnSupprimer.Location = new System.Drawing.Point(379, 290);
            this.btnSupprimer.MinimumSize = new System.Drawing.Size(94, 30);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(172, 30);
            this.btnSupprimer.TabIndex = 29;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAbsences
            // 
            this.btnAbsences.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbsences.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.btnAbsences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbsences.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnAbsences.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btnAbsences.Location = new System.Drawing.Point(379, 370);
            this.btnAbsences.MinimumSize = new System.Drawing.Size(94, 30);
            this.btnAbsences.Name = "btnAbsences";
            this.btnAbsences.Size = new System.Drawing.Size(172, 30);
            this.btnAbsences.TabIndex = 30;
            this.btnAbsences.Text = "Absences";
            this.btnAbsences.UseVisualStyleBackColor = false;
            this.btnAbsences.Click += new System.EventHandler(this.btnAbsences_Click);
            // 
            // tblSaisie
            // 
            this.tblSaisie.ColumnCount = 1;
            this.tblSaisie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSaisie.Controls.Add(this.cboServices, 0, 4);
            this.tblSaisie.Controls.Add(this.txtMail, 0, 3);
            this.tblSaisie.Controls.Add(this.txtTel, 0, 2);
            this.tblSaisie.Controls.Add(this.txtNom, 0, 0);
            this.tblSaisie.Controls.Add(this.txtPrenom, 0, 1);
            this.tblSaisie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSaisie.Location = new System.Drawing.Point(704, 28);
            this.tblSaisie.Name = "tblSaisie";
            this.tblSaisie.RowCount = 5;
            this.tlpContenu.SetRowSpan(this.tblSaisie, 5);
            this.tblSaisie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblSaisie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblSaisie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblSaisie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblSaisie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblSaisie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblSaisie.Size = new System.Drawing.Size(229, 394);
            this.tblSaisie.TabIndex = 31;
            // 
            // cboServices
            // 
            this.cboServices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.cboServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServices.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cboServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.cboServices.FormattingEnabled = true;
            this.cboServices.Location = new System.Drawing.Point(3, 341);
            this.cboServices.Name = "cboServices";
            this.cboServices.Size = new System.Drawing.Size(223, 29);
            this.cboServices.TabIndex = 4;
            // 
            // txtMail
            // 
            this.txtMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.txtMail.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.txtMail.Location = new System.Drawing.Point(3, 259);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(223, 28);
            this.txtMail.TabIndex = 3;
            // 
            // txtTel
            // 
            this.txtTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.txtTel.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.txtTel.Location = new System.Drawing.Point(3, 181);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(223, 28);
            this.txtTel.TabIndex = 2;
            // 
            // txtNom
            // 
            this.txtNom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.txtNom.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.txtNom.Location = new System.Drawing.Point(3, 25);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(223, 28);
            this.txtNom.TabIndex = 0;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrenom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.txtPrenom.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtPrenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.txtPrenom.Location = new System.Drawing.Point(3, 103);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(223, 28);
            this.txtPrenom.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(17)))), ((int)(((byte)(69)))));
            this.tlpGeneralLayout.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 96);
            this.panel1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Script MT Bold", 28F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1076, 96);
            this.label7.TabIndex = 2;
            this.label7.Text = "Gestion du personnel";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // personnelBindingSource
            // 
            this.personnelBindingSource.DataSource = typeof(MediaTek.Modele.Personnel);
            // 
            // FrmPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.tlpGeneralLayout);
            this.Name = "FrmPersonnel";
            this.Text = "Gestion du personnel";
            this.tlpGeneralLayout.ResumeLayout(false);
            this.tlpContenu.ResumeLayout(false);
            this.tlpContenu.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlOKButtons.ResumeLayout(false);
            this.tblSaisie.ResumeLayout(false);
            this.tblSaisie.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpGeneralLayout;
        private System.Windows.Forms.TableLayoutPanel tlpContenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstPersonnel;
        private System.Windows.Forms.Label lblTitreChoix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAbsences;
        private System.Windows.Forms.TableLayoutPanel tblSaisie;
        private System.Windows.Forms.ComboBox cboServices;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Panel pnlOKButtons;
        private System.Windows.Forms.Button btnOKEdit;
        private System.Windows.Forms.Button btnOKAjout;
        private System.Windows.Forms.BindingSource personnelBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
    }
}