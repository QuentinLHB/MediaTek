namespace MediaTek.Vue
{
    partial class FrmAbsences
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
            this.tlpGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.lblNomPersonnel = new System.Windows.Forms.Label();
            this.lstAbsences = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.cboMotifs = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlOKButtons = new System.Windows.Forms.Panel();
            this.btnOKEdit = new System.Windows.Forms.Button();
            this.btnOKAjout = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblMode = new System.Windows.Forms.Label();
            this.tlpGeneral.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlOKButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpGeneral
            // 
            this.tlpGeneral.ColumnCount = 7;
            this.tlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.052607F));
            this.tlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.36384F));
            this.tlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.64206F));
            this.tlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.24681F));
            this.tlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.64206F));
            this.tlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.052608F));
            this.tlpGeneral.Controls.Add(this.lblNomPersonnel, 1, 1);
            this.tlpGeneral.Controls.Add(this.lstAbsences, 1, 2);
            this.tlpGeneral.Controls.Add(this.tableLayoutPanel2, 2, 2);
            this.tlpGeneral.Controls.Add(this.label2, 4, 2);
            this.tlpGeneral.Controls.Add(this.label3, 4, 3);
            this.tlpGeneral.Controls.Add(this.label4, 4, 4);
            this.tlpGeneral.Controls.Add(this.dtpDebut, 5, 2);
            this.tlpGeneral.Controls.Add(this.dtpFin, 5, 3);
            this.tlpGeneral.Controls.Add(this.cboMotifs, 5, 4);
            this.tlpGeneral.Controls.Add(this.label5, 1, 0);
            this.tlpGeneral.Controls.Add(this.pnlOKButtons, 4, 5);
            this.tlpGeneral.Controls.Add(this.btnAnnuler, 5, 5);
            this.tlpGeneral.Controls.Add(this.lblMode, 4, 1);
            this.tlpGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGeneral.Location = new System.Drawing.Point(0, 0);
            this.tlpGeneral.Name = "tlpGeneral";
            this.tlpGeneral.RowCount = 7;
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.14814F));
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.70371F));
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.14815F));
            this.tlpGeneral.Size = new System.Drawing.Size(882, 503);
            this.tlpGeneral.TabIndex = 0;
            // 
            // lblNomPersonnel
            // 
            this.lblNomPersonnel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomPersonnel.AutoSize = true;
            this.tlpGeneral.SetColumnSpan(this.lblNomPersonnel, 2);
            this.lblNomPersonnel.Location = new System.Drawing.Point(63, 87);
            this.lblNomPersonnel.Name = "lblNomPersonnel";
            this.lblNomPersonnel.Size = new System.Drawing.Size(415, 17);
            this.lblNomPersonnel.TabIndex = 0;
            this.lblNomPersonnel.Text = "Absences de :";
            this.lblNomPersonnel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstAbsences
            // 
            this.lstAbsences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAbsences.FormattingEnabled = true;
            this.lstAbsences.ItemHeight = 16;
            this.lstAbsences.Location = new System.Drawing.Point(63, 107);
            this.lstAbsences.Name = "lstAbsences";
            this.tlpGeneral.SetRowSpan(this.lstAbsences, 4);
            this.lstAbsences.Size = new System.Drawing.Size(290, 317);
            this.lstAbsences.TabIndex = 1;
            this.lstAbsences.DoubleClick += new System.EventHandler(this.lstAbsences_DoubleClick);
            this.lstAbsences.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstAbsences_KeyUp);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnAjouter, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnModifier, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnSupprimer, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(359, 107);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tlpGeneral.SetRowSpan(this.tableLayoutPanel2, 4);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.8125F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.125F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.125F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.125F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.8125F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(119, 317);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouter.Location = new System.Drawing.Point(3, 48);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(113, 40);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifier.Location = new System.Drawing.Point(3, 137);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(113, 40);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimer.Location = new System.Drawing.Point(3, 226);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(113, 40);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(568, 114);
            this.label2.MinimumSize = new System.Drawing.Size(0, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Début absence : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 164);
            this.label3.MinimumSize = new System.Drawing.Size(0, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fin absence : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 214);
            this.label4.MinimumSize = new System.Drawing.Size(0, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Motif : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpDebut
            // 
            this.dtpDebut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDebut.Location = new System.Drawing.Point(698, 114);
            this.dtpDebut.MinimumSize = new System.Drawing.Size(4, 30);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(119, 30);
            this.dtpDebut.TabIndex = 6;
            // 
            // dtpFin
            // 
            this.dtpFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(698, 164);
            this.dtpFin.MinimumSize = new System.Drawing.Size(4, 30);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(119, 30);
            this.dtpFin.TabIndex = 7;
            // 
            // cboMotifs
            // 
            this.cboMotifs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMotifs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMotifs.FormattingEnabled = true;
            this.cboMotifs.Location = new System.Drawing.Point(698, 216);
            this.cboMotifs.Name = "cboMotifs";
            this.cboMotifs.Size = new System.Drawing.Size(119, 24);
            this.cboMotifs.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.tlpGeneral.SetColumnSpan(this.label5, 5);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(754, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gestion des absences";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlOKButtons
            // 
            this.pnlOKButtons.Controls.Add(this.btnOKEdit);
            this.pnlOKButtons.Controls.Add(this.btnOKAjout);
            this.pnlOKButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOKButtons.Location = new System.Drawing.Point(568, 257);
            this.pnlOKButtons.Name = "pnlOKButtons";
            this.pnlOKButtons.Size = new System.Drawing.Size(124, 167);
            this.pnlOKButtons.TabIndex = 12;
            // 
            // btnOKEdit
            // 
            this.btnOKEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOKEdit.Location = new System.Drawing.Point(0, 3);
            this.btnOKEdit.MinimumSize = new System.Drawing.Size(0, 30);
            this.btnOKEdit.Name = "btnOKEdit";
            this.btnOKEdit.Size = new System.Drawing.Size(121, 40);
            this.btnOKEdit.TabIndex = 12;
            this.btnOKEdit.Text = "OK";
            this.btnOKEdit.UseVisualStyleBackColor = true;
            this.btnOKEdit.Click += new System.EventHandler(this.btnOKEdit_Click);
            // 
            // btnOKAjout
            // 
            this.btnOKAjout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOKAjout.Location = new System.Drawing.Point(-3, 3);
            this.btnOKAjout.MinimumSize = new System.Drawing.Size(0, 30);
            this.btnOKAjout.Name = "btnOKAjout";
            this.btnOKAjout.Size = new System.Drawing.Size(124, 40);
            this.btnOKAjout.TabIndex = 11;
            this.btnOKAjout.Text = "OK";
            this.btnOKAjout.UseVisualStyleBackColor = true;
            this.btnOKAjout.Click += new System.EventHandler(this.btnOKAjout_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnuler.Location = new System.Drawing.Point(698, 257);
            this.btnAnnuler.MinimumSize = new System.Drawing.Size(0, 30);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(119, 40);
            this.btnAnnuler.TabIndex = 11;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // lblMode
            // 
            this.lblMode.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMode.AutoSize = true;
            this.tlpGeneral.SetColumnSpan(this.lblMode, 2);
            this.lblMode.Location = new System.Drawing.Point(669, 87);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(46, 17);
            this.lblMode.TabIndex = 13;
            this.lblMode.Text = "label1";
            // 
            // FrmAbsences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.tlpGeneral);
            this.Name = "FrmAbsences";
            this.Text = "Absences";
            this.tlpGeneral.ResumeLayout(false);
            this.tlpGeneral.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlOKButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpGeneral;
        private System.Windows.Forms.Label lblNomPersonnel;
        private System.Windows.Forms.ListBox lstAbsences;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.ComboBox cboMotifs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Panel pnlOKButtons;
        private System.Windows.Forms.Button btnOKEdit;
        private System.Windows.Forms.Button btnOKAjout;
        private System.Windows.Forms.Label lblMode;
    }
}