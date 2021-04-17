using System;
using System.ComponentModel;
using System.Windows.Forms;
using MediaTek.Modele;
using MediaTek.Controleur;

namespace MediaTek.Vue
{
    
    public partial class FrmPersonnel : Form
    {
        /// <summary>
        /// Liste faisant le lien entre les personnels et la listbox les contenant.
        /// </summary>
        BindingList<Personnel> bindingList;


        /*
         * Constantes de mode, permettant d'ajuster la visibilité des boutons en fonction du contexte.
         */
        private const int MODIFICATION = 2;
        private const int AJOUT = 1;

        /// <summary>
        /// Instance du controleur
        /// </summary>
        private Controle controle;

        /// <summary>
        /// Constructueur : Initialise les objets graphiques, leur contenu, et le contrôleur.
        /// </summary>
        /// <param name="controle">Contrôleur</param>
        public FrmPersonnel(Controle controle)
        {
            this.controle = controle;
            InitializeComponent();
            init();
            this.ShowDialog();
        }

        /// <summary>
        /// Remplit la liste des personnels et le combo des services. Initialise les accès aux objets de saisie.
        /// </summary>
        public void init()
        {
            bindingList = new BindingList<Personnel>(controle.LesPersonnels);
            lstPersonnel.DataSource = bindingList;
            AccesEditionPersonnel(false);

            foreach(string service in Personnel.Services.Values)
            {
                cboServices.Items.Add(service);
            }
            try
            {
                 cboServices.SelectedIndex = 1;
            }
            catch
            {
                MessageBox.Show("Les données n'ont pas pu être chargées. Vérifiez votre connexion à la base de données.");
            }
        }

        /*
         * Procédures évènementielles
         */
        /// <summary>
        /// Ouvre le formulaire de gestion d'absences si un personnel est sélectionné.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbsences_Click(object sender, EventArgs e)
        {
            if(lstPersonnel.SelectedIndex != -1)
            {
                FrmAbsences frmAbsences = new FrmAbsences(controle, (Personnel)lstPersonnel.SelectedItem);
                frmAbsences.ShowDialog();
            }
            else
            {
                ErreurPasDeSelection();
            }
  
        }

        /// <summary>
        /// Ouvre l'accès aux zones de saisie d'un nouveau personnel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            AccesEditionPersonnel(true, AJOUT);
            txtNom.Focus();
        }

        /// <summary>
        /// Permet l'édition du contact sélectionné.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (lstPersonnel.SelectedIndex != -1)
            {
                Personnel personnel = (Personnel)lstPersonnel.SelectedItem;
                txtNom.Text = personnel.Nom;
                txtPrenom.Text = personnel.Prenom;
                txtTel.Text = personnel.Tel;
                txtMail.Text = personnel.Mail;
                cboServices.SelectedItem = personnel.Service;

                AccesEditionPersonnel(true, MODIFICATION);
                txtNom.Focus();
            }

            else
            {
                ErreurPasDeSelection();
            }
        }

        /// <summary>
        /// Supprime le personnel sélectionné, après confirmation de l'utilisateur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (lstPersonnel.SelectedIndex != -1)
            {
                Personnel personnel = (Personnel)lstPersonnel.SelectedItem;
                DialogResult choix = MessageBox.Show($"Voulez vous vraiment supprimer {personnel.Nom} {personnel.Prenom} ?",
                "Confirmation", MessageBoxButtons.YesNo);
                if (choix == DialogResult.Yes)
                {
                    controle.SupprPersonnel(personnel);
                    bindingList.ResetBindings();
                    VideSaisie();
                }
            }
            else
            {
                ErreurPasDeSelection();
            }
        }

        /// <summary>
        /// Raccourci de l'édition de contact, avec un double clic.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstPersonnel_DoubleClick(object sender, EventArgs e)
        {
            btnModifier_Click(null, null);
        }
        /// <summary>
        /// Annule la saisie : Réinitialise les champs et empêche la saisie d'informations.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            VideSaisie();
            AccesEditionPersonnel(false);
        }

        /// <summary>
        /// Raccourci du bouton "Supprimer", avec la touche "Suppr".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstPersonnel_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnSupprimer_Click(null, null);
            }
        }

        /// <summary>
        /// Ajoute un personnel avec les informations entrées.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (VerifieChamps())
            {
                controle.AjoutPersonnel(txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, cboServices.SelectedIndex+1);
                ValidationBtnOK();
            }
            else
            {
                ErreurChampsVides();
            }            

        }

        /// <summary>
        /// Edite le personnel sélectionné avec les informations entrées.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOKEdit_Click(object sender, EventArgs e)
        {
            if (VerifieChamps())
            {
                DialogResult choix = MessageBox.Show("Confirmer la modification ?",
                "Confirmation", MessageBoxButtons.YesNo);
                if (choix == DialogResult.Yes)
                {
                    controle.ModifPersonnel((Personnel)lstPersonnel.SelectedItem, txtNom.Text, txtPrenom.Text, txtMail.Text, txtTel.Text, cboServices.SelectedIndex + 1);
                    ValidationBtnOK();
                }
            }
            else ErreurChampsVides();           
        }

        /*
         * Fonctions
         */

        /// <summary>
        /// Affiche un message d'erreur si aucun personnel n'est sélectionné.
        /// </summary>
        private void ErreurPasDeSelection()
        {
            MessageBox.Show("Aucun personnel n'est sélectionné.", "Action impossible.");
        }

        private void ErreurChampsVides()
        {
            MessageBox.Show("Merci de compléter tous les champs.", "Action impossible");
        }

        /// <summary>
        /// Actualise la liste du personnel et ferme l'accès à la zone de saisie.
        /// </summary>
        private void ValidationBtnOK()
        {
            bindingList.ResetBindings();
            VideSaisie();
            AccesEditionPersonnel(false);            
        }

        /// <summary>
        /// Gère l'accès aux controles d'édition de personnel (textbox, bouttons, liste du personnel).
        /// </summary>
        /// <param name="acces">True donne l'accès, false le retire.</param>
        public void AccesEditionPersonnel(bool acces, int mode = 0)
        {
            lstPersonnel.Enabled = !acces;
            tblSaisie.Enabled = acces;
            pnlOKButtons.Enabled = acces;
            btnAnnuler.Enabled = acces;


            switch (mode)
            {
                case MODIFICATION: btnOKEdit.Visible = true; btnOKAjout.Visible = false; lblTitreChoix.Text = "Modifier"; break;
                case AJOUT: btnOKEdit.Visible = false; btnOKAjout.Visible = true; lblTitreChoix.Text = "Ajouter";  break;
                default: btnOKEdit.Visible = true; btnOKAjout.Visible = false; lblTitreChoix.Text = ""; break;
            }
        }

        /// <summary>
        /// Vide les textbox et réinitialise le combo.
        /// </summary>
        private void VideSaisie()
        {
            foreach (Control control in tblSaisie.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
            cboServices.SelectedIndex = 0;
        }

        /// <summary>
        /// Vérifie si les champs sont tous complétés.
        /// </summary>
        /// <returns></returns>
        private bool VerifieChamps()
        {
            foreach (Control control in tblSaisie.Controls)
            {
                if (control is TextBox && control.Text == "")
                {
                    return false;
                }
            }
            return true;
        }


    }
}
