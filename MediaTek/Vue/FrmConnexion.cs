using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaTek.Controleur;

namespace MediaTek.Vue
{
    public partial class FrmConnexion : Form
    {
        public Controle controle;

        public FrmConnexion(Controle controle)
        {
            this.controle = controle;
            InitializeComponent();
            txtMdp.UseSystemPasswordChar = true;           

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if(txtIdentifiant.Text != string.Empty && txtMdp.Text != string.Empty)
            {
                controle.Authentification(txtIdentifiant.Text, txtMdp.Text);                
            }

            else
            {
                MessageBox.Show("Veuillez saisir tous les champs.", "Connexion impossible");
            }
        }
    }
}
