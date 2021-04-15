namespace MediaTek.Vue
{
    partial class FrmConnexion
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
            this.tlpLoginPwd = new System.Windows.Forms.TableLayoutPanel();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tlpLoginPwd.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpLoginPwd
            // 
            this.tlpLoginPwd.AutoSize = true;
            this.tlpLoginPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.tlpLoginPwd.ColumnCount = 4;
            this.tlpLoginPwd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLoginPwd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLoginPwd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLoginPwd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLoginPwd.Controls.Add(this.txtMdp, 2, 3);
            this.tlpLoginPwd.Controls.Add(this.lblPwd, 1, 3);
            this.tlpLoginPwd.Controls.Add(this.txtIdentifiant, 2, 2);
            this.tlpLoginPwd.Controls.Add(this.lblLogin, 1, 2);
            this.tlpLoginPwd.Controls.Add(this.btnValider, 2, 4);
            this.tlpLoginPwd.Controls.Add(this.label1, 1, 0);
            this.tlpLoginPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLoginPwd.Location = new System.Drawing.Point(0, 0);
            this.tlpLoginPwd.Name = "tlpLoginPwd";
            this.tlpLoginPwd.RowCount = 6;
            this.tlpLoginPwd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.61905F));
            this.tlpLoginPwd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tlpLoginPwd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpLoginPwd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpLoginPwd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpLoginPwd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.61905F));
            this.tlpLoginPwd.Size = new System.Drawing.Size(466, 225);
            this.tlpLoginPwd.TabIndex = 0;
            // 
            // txtMdp
            // 
            this.txtMdp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMdp.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtMdp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.txtMdp.Location = new System.Drawing.Point(236, 97);
            this.txtMdp.MaximumSize = new System.Drawing.Size(200, 35);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(150, 28);
            this.txtMdp.TabIndex = 5;
            // 
            // lblPwd
            // 
            this.lblPwd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPwd.Location = new System.Drawing.Point(109, 99);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(121, 20);
            this.lblPwd.TabIndex = 4;
            this.lblPwd.Text = "Mot de passe : ";
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIdentifiant.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtIdentifiant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.txtIdentifiant.Location = new System.Drawing.Point(236, 67);
            this.txtIdentifiant.MaximumSize = new System.Drawing.Size(200, 35);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(150, 28);
            this.txtIdentifiant.TabIndex = 1;
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblLogin.Location = new System.Drawing.Point(135, 69);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(95, 20);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Identifiant : ";
            // 
            // btnValider
            // 
            this.btnValider.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnValider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.btnValider.Location = new System.Drawing.Point(236, 127);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(122, 34);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Connexion";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(134, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Connexion :";
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 225);
            this.Controls.Add(this.tlpLoginPwd);
            this.Name = "FrmConnexion";
            this.Text = "Form1";
            this.tlpLoginPwd.ResumeLayout(false);
            this.tlpLoginPwd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpLoginPwd;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label label1;
    }
}

