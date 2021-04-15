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
        /// <summary>
        /// Instance du contrôleur.
        /// </summary>
        public Controle controle;

        public FrmConnexion(Controle controle)
        {
            this.controle = controle;
            InitializeComponent();
            txtMdp.UseSystemPasswordChar = true;           

        }

        /// <summary>
        /// Procède à l'authentification en fonction des données de connexion entrées.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider_Click(object sender, EventArgs e)
        {
            if(txtIdentifiant.Text != string.Empty && txtMdp.Text != string.Empty)
            {
                controle.Authentification(txtIdentifiant.Text, txtMdp.Text);                
            }

            else
            {
                ErreurConnexion();
            }
        }

        /// <summary>
        /// Affiche une erreur de connexion si celle-ci n'est pas validée.
        /// </summary>
        public void ErreurConnexion()
        {
            MessageBox.Show("Erreur de connexion, merci de réessayer.", "Connexion impossible");
            txtIdentifiant.Focus();
        }
    }
}
