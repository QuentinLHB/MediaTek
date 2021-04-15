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
        private Controle controle;
        private Personnel personnel;
        private BindingList<Absence> bindingList;
        private const int MODIFICATION = 2;
        private const int AJOUT = 1;

        public FrmAbsences(Controle controle, Personnel personnel)
        {
            this.controle = controle;
            this.personnel = personnel;
            InitializeComponent();
            init();
        }

        public void init()
        {
            bindingList = new BindingList<Absence>(personnel.Absences);
            lstAbsences.DataSource = bindingList;
            lblNomPersonnel.Text = $"Absences de : {personnel.Prenom} {personnel.Nom}";
            foreach(string motif in Absence.Motifs.Values)
            {
                cboMotifs.Items.Add(motif);
            }

            accederEditionAbences(false);
        }

        public void accederEditionAbences(bool acces, int mode = 0)
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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            accederEditionAbences(true, AJOUT);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            accederEditionAbences(true, MODIFICATION);
            Absence absence = (Absence)lstAbsences.SelectedItem;
            dtpDebut.Value = absence.DateDebut;
            dtpFin.Value = absence.DateFin;
            cboMotifs.SelectedItem = Absence.Motifs[absence.Motif];
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult choix = MessageBox.Show($"Confirmer la suppression ?", "Confirmation", MessageBoxButtons.YesNo);
            if (choix == DialogResult.Yes)
            {
                controle.SupprAbsence(personnel, (Absence)lstAbsences.SelectedItem);
                bindingList.ResetBindings();
            }
        }

        private void btnOKEdit_Click(object sender, EventArgs e)
        {
            DialogResult choix = MessageBox.Show($"Confirmer la modification ?", "Confirmation", MessageBoxButtons.YesNo);
            if (choix == DialogResult.Yes)
            {
                if (controle.ModifAbsence((Absence)lstAbsences.SelectedItem, dtpDebut.Value, dtpFin.Value, cboMotifs.SelectedIndex + 1))
                {
                    bindingList.ResetBindings();
                    reinitialiseChamps();
                }

                else
                {
                    MessageBox.Show("Une absence est déjà enregistrée avec cette date de début.", "Erreur");
                }
            }                
        }

        private void btnOKAjout_Click(object sender, EventArgs e)
        {
            if (controle.AjoutAbsence(personnel, dtpDebut.Value, dtpFin.Value, cboMotifs.SelectedIndex + 1))
            {
                bindingList.ResetBindings();
                reinitialiseChamps();
            }
            else
            {
                MessageBox.Show("Une absence est déjà enregistrée avec cette date de début.", "Erreur");
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            reinitialiseChamps();
        }

        private void reinitialiseChamps()
        {
            dtpDebut.Value = DateTime.Today;
            dtpFin.Value = DateTime.Today;
            cboMotifs.SelectedIndex = 0;
            accederEditionAbences(false);
        }

        private void lstAbsences_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnSupprimer_Click(null, null);
            }
        }

        private void lstAbsences_DoubleClick(object sender, EventArgs e)
        {
            btnModifier_Click(null, null);
        }
    }
}
