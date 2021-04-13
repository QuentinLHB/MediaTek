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
            this.tlpGeneralLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lstPersonnel = new System.Windows.Forms.ListBox();
            this.lblTitreChoix = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cboServices = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAbsences = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tlpGeneralLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpGeneralLayout
            // 
            this.tlpGeneralLayout.ColumnCount = 3;
            this.tlpGeneralLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.5163F));
            this.tlpGeneralLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.96741F));
            this.tlpGeneralLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.5163F));
            this.tlpGeneralLayout.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.tlpGeneralLayout.Controls.Add(this.label7, 1, 0);
            this.tlpGeneralLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGeneralLayout.Location = new System.Drawing.Point(0, 0);
            this.tlpGeneralLayout.Name = "tlpGeneralLayout";
            this.tlpGeneralLayout.RowCount = 3;
            this.tlpGeneralLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpGeneralLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tlpGeneralLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpGeneralLayout.Size = new System.Drawing.Size(800, 450);
            this.tlpGeneralLayout.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.80053F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.07693F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.17454F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.94801F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lstPersonnel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTitreChoix, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtNom, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPrenom, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTel, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtMail, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.cboServices, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnAjouter, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnModifier, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSupprimer, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnAbsences, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(79, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(641, 315);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personnel";
            // 
            // lstPersonnel
            // 
            this.lstPersonnel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPersonnel.FormattingEnabled = true;
            this.lstPersonnel.ItemHeight = 16;
            this.lstPersonnel.Location = new System.Drawing.Point(3, 28);
            this.lstPersonnel.Name = "lstPersonnel";
            this.tableLayoutPanel1.SetRowSpan(this.lstPersonnel, 6);
            this.lstPersonnel.Size = new System.Drawing.Size(162, 284);
            this.lstPersonnel.TabIndex = 1;
            // 
            // lblTitreChoix
            // 
            this.lblTitreChoix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitreChoix.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblTitreChoix, 2);
            this.lblTitreChoix.Location = new System.Drawing.Point(491, 0);
            this.lblTitreChoix.Name = "lblTitreChoix";
            this.lblTitreChoix.Size = new System.Drawing.Size(58, 25);
            this.lblTitreChoix.TabIndex = 13;
            this.lblTitreChoix.Text = "Modifier";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nom :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Prénom : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tel. :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Mail :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Service : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNom
            // 
            this.txtNom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNom.Location = new System.Drawing.Point(478, 38);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(160, 22);
            this.txtNom.TabIndex = 20;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrenom.Location = new System.Drawing.Point(478, 86);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(160, 22);
            this.txtPrenom.TabIndex = 21;
            // 
            // txtTel
            // 
            this.txtTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTel.Location = new System.Drawing.Point(478, 134);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(160, 22);
            this.txtTel.TabIndex = 22;
            // 
            // txtMail
            // 
            this.txtMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMail.Location = new System.Drawing.Point(478, 182);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(160, 22);
            this.txtMail.TabIndex = 23;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnAnnuler, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnOK, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(478, 268);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(160, 44);
            this.tableLayoutPanel2.TabIndex = 24;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnnuler.Location = new System.Drawing.Point(83, 3);
            this.btnAnnuler.MinimumSize = new System.Drawing.Size(74, 38);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(74, 38);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOK.Location = new System.Drawing.Point(3, 3);
            this.btnOK.MinimumSize = new System.Drawing.Size(74, 38);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(74, 38);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // cboServices
            // 
            this.cboServices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboServices.FormattingEnabled = true;
            this.cboServices.Location = new System.Drawing.Point(478, 228);
            this.cboServices.Name = "cboServices";
            this.cboServices.Size = new System.Drawing.Size(160, 24);
            this.cboServices.TabIndex = 25;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouter.Location = new System.Drawing.Point(171, 82);
            this.btnAjouter.MinimumSize = new System.Drawing.Size(94, 30);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(124, 30);
            this.btnAjouter.TabIndex = 26;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifier.Location = new System.Drawing.Point(171, 130);
            this.btnModifier.MinimumSize = new System.Drawing.Size(94, 30);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(124, 30);
            this.btnModifier.TabIndex = 28;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimer.Location = new System.Drawing.Point(171, 178);
            this.btnSupprimer.MinimumSize = new System.Drawing.Size(94, 30);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(124, 30);
            this.btnSupprimer.TabIndex = 29;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnAbsences
            // 
            this.btnAbsences.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbsences.Location = new System.Drawing.Point(171, 226);
            this.btnAbsences.MinimumSize = new System.Drawing.Size(94, 30);
            this.btnAbsences.Name = "btnAbsences";
            this.btnAbsences.Size = new System.Drawing.Size(124, 30);
            this.btnAbsences.TabIndex = 30;
            this.btnAbsences.Text = "Absences";
            this.btnAbsences.UseVisualStyleBackColor = true;
            this.btnAbsences.Click += new System.EventHandler(this.btnAbsences_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(264, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 31);
            this.label7.TabIndex = 1;
            this.label7.Text = "Gestion du personnel";
            // 
            // FrmPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpGeneralLayout);
            this.Name = "FrmPersonnel";
            this.Text = "Gestion du personnel";
            this.tlpGeneralLayout.ResumeLayout(false);
            this.tlpGeneralLayout.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpGeneralLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstPersonnel;
        private System.Windows.Forms.Label lblTitreChoix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.ComboBox cboServices;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAbsences;
        private System.Windows.Forms.Label label7;
    }
}