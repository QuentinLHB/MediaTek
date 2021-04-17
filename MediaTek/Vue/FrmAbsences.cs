using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaTek.Modele;
using MediaTek.Controleur;

namespace MediaTek.Vue
{
    public partial class FrmAbsences : Form
    {
        /// <summary>
        /// Instance du contrôleur.
        /// </summary>
        private Controle controle;

        /// <summary>
        /// Personnel sélectionné à l'ouverture du formulaire.
        /// </summary>
        private Personnel personnel;

        /// <summary>
        /// Liste faisant le lien entre la liste des absences du personnel et l'objet graphique listbox.
        /// </summary>
        private BindingList<Absence> bindingList;

        /*
         * Constantes représentant les modes d'ajout et de modification.
         */
        private const int MODIFICATION = 2;
        private const int AJOUT = 1;

        /// <summary>
        /// Constructeur du formulaire : Initialise les objets graphiques, leur contenu, et l'accès à la zone de saisie.
        /// </summary>
        /// <param name="controle">Instance du contrôleur</param>
        /// <param name="personnel">Personnel sélectionné dans le formulaire de personnel.</param>
        public FrmAbsences(Controle controle, Personnel personnel)
        {
            this.controle = controle;
            this.personnel = personnel;
            InitializeComponent();
            init();
        }

        /// <summary>
        /// Initialise le contenu des objets graphiques.
        /// </summary>
        public void init()
        {
            bindingList = new BindingList<Absence>(personnel.Absences);
            lstAbsences.DataSource = bindingList;
            lblNomPersonnel.Text = $"Absences de : {personnel.Prenom} {personnel.Nom}";
            foreach(string motif in Absence.Motifs.Values)
            {
                cboMotifs.Items.Add(motif);
            }
            cboMotifs.SelectedIndex = 0;

            AccederEditionAbences(false);
        }

        /// <summary>
        /// Donne l'accès à la zone d'ajout d'absence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            AccederEditionAbences(true, AJOUT);            
        }

        /// <summary>
        /// Donne l'accès à la zone d'édition d'absence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (lstAbsences.SelectedIndex != -1)
            {
                AccederEditionAbences(true, MODIFICATION);
                Absence absence = (Absence)lstAbsences.SelectedItem;
                dtpDebut.Value = absence.DateDebut;
                dtpFin.Value = absence.DateFin;
                cboMotifs.SelectedItem = Absence.Motifs[absence.Motif];
            }
            else ErreurPasDeSelection();            
        }

        /// <summary>
        /// Supprime l'absence sélectionnée après confirmation de l'utilisateur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (lstAbsences.SelectedIndex != -1)
            {
                DialogResult choix = MessageBox.Show($"Confirmer la suppression ?", "Confirmation", MessageBoxButtons.YesNo);
                if (choix == DialogResult.Yes)
                {
                    controle.SupprAbsence((Absence)lstAbsences.SelectedItem);
                    bindingList.ResetBindings();
                }
            }
            else ErreurPasDeSelection();

        }

        /// <summary>
        /// Modifie l'abence sélectionnée après confirmation de l'utilisateur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOKEdit_Click(object sender, EventArgs e)
        {
            Absence absenceSelectionnee = (Absence)lstAbsences.SelectedItem;
            Absence absenceExistante = controle.VerifieDateUnique(personnel, dtpDebut.Value);
            if (absenceExistante == null)
            {
                ConfirmationModification(absenceSelectionnee);
            }    
            else
            {
                if (absenceSelectionnee == absenceExistante) ConfirmationModification(absenceExistante);
                else MessageBox.Show("Une absence a déjà été enregistrée avec cette date de début", "Modification impossible");
            }        
        }

        private void ConfirmationModification(Absence absence)
        {
            DialogResult choix = MessageBox.Show($"Confirmer la modification de l'absence :\n{absence} ?", "Confirmation", MessageBoxButtons.YesNo);
            if (choix == DialogResult.Yes)
            {
                controle.ModifAbsence(absence, dtpDebut.Value, dtpFin.Value, cboMotifs.SelectedIndex + 1);
                ReinitialiseChamps();
                ReinitialiseBinding();
            }
        }
        /// <summary>
        /// Ajoute l'abence après confirmation de l'utilisateur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOKAjout_Click(object sender, EventArgs e)
        {
            if (controle.AjoutAbsence(personnel, dtpDebut.Value, dtpFin.Value, cboMotifs.SelectedIndex + 1))
            {
                ReinitialiseBinding();
                ReinitialiseChamps();
            }
            else
            {
                MessageBox.Show("Une absence est déjà enregistrée avec cette date de début.", "Erreur");
            }
        }

        /// <summary>
        /// Annule la saisie: Réinitialisation des champs et fermeture de l'accès à la zone de saisie.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            ReinitialiseChamps();
        }

        /// <summary>
        /// Raccourci de suppression d'une absence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstAbsences_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnSupprimer_Click(null, null);
            }
        }

        /// <summary>
        /// Raccourci de modification d'une absence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstAbsences_DoubleClick(object sender, EventArgs e)
        {
            btnModifier_Click(null, null);
        }

        /// <summary>
        /// Gère l'accès aux controles d'édition des absences.
        /// </summary>
        /// <param name="acces">True pour donner l'accès, false pour l'enlever.</param>
        /// <param name="mode">1 : Ajout; 2 : Modification.</param>
        public void AccederEditionAbences(bool acces, int mode = 0)
        {
            lstAbsences.Enabled = !acces;
            dtpDebut.Enabled = acces;
            dtpFin.Enabled = acces;
            cboMotifs.Enabled = acces;
            pnlOKButtons.Enabled = acces;
            btnAnnuler.Enabled = acces;
            switch (mode)
            {
                case MODIFICATION: btnOKEdit.Visible = true; btnOKAjout.Visible = false; lblMode.Text = "Modifier"; break;
                case AJOUT: btnOKEdit.Visible = false; btnOKAjout.Visible = true; lblMode.Text = "Ajouter"; break;
                default: btnOKEdit.Visible = true; btnOKAjout.Visible = false; lblMode.Text = ""; break;
            }
        }

        /// <summary>
        /// Réinitialise les champs de la zone de saisie.
        /// </summary>
        private void ReinitialiseChamps()
        {
            dtpDebut.Value = DateTime.Today;
            dtpFin.Value = DateTime.Today;
            cboMotifs.SelectedIndex = 0;
            AccederEditionAbences(false);
        }

        /// <summary>
        /// Affichage d'erreur quand aucune absence n'est sélectionnée.
        /// </summary>
        private void ErreurPasDeSelection()
        {
            MessageBox.Show("Aucune absence n'est sélectionnée ", "Action impossible");
        }

        private void ReinitialiseBinding()
        {
            bindingList = new BindingList<Absence>(personnel.Absences);
            lstAbsences.DataSource = bindingList;
        }
    }
}
