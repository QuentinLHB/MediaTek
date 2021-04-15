using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaTek.Modele;
using MediaTek.Vue;
using MediaTek.Connexion;
using MediaTek.dal;
using System.Windows.Forms;

namespace MediaTek.Controleur
{
    public class Controle
    {
        private List<Personnel> lesPersonnels;
        public List<Personnel> LesPersonnels { get => lesPersonnels; }
        private FrmPersonnel frmPersonnel;
        private FrmAbsences frmAbsences;
        private FrmConnexion frmConnexion;

        public Controle()
        {
            frmConnexion = new FrmConnexion(this);
            frmConnexion.ShowDialog();

        }

        public void Authentification(string login, string pwd) // DECOMMENTER
        {
            if (AccesDonnees.ControleAuthentification(login, pwd))
            {
                frmConnexion.Hide();
                lesPersonnels = GetPersonnels();
                frmPersonnel = new FrmPersonnel(this);
            }

            else
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect.", "Connexion impossible");
            }
        }

        public List<Personnel> GetPersonnels()
        {
            return AccesDonnees.GetPersonnels();
        }

        /// <summary>
        /// Ajout d'un nouveau personnel à la base de données, et affichage.
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="mail"></param>
        /// <param name="tel"></param>
        /// <param name="idService"></param>
        public void AjoutPersonnel(string nom, string prenom, string mail, string tel, int idService)
        {          
            
            Personnel nvoPersonnel = new Personnel(nom, prenom, tel, mail, idService);
            lesPersonnels.Add(nvoPersonnel);
            AccesDonnees.AjoutPersonnel(nvoPersonnel);
            nvoPersonnel.IdPersonnel = AccesDonnees.GetMaxIdPersonnel();
        }

        /// <summary>
        /// Modification des informations d'un personnel dans la base données, et affichage de la modification.
        /// </summary>
        /// <param name="personnel">Personnel concerné.</param>
        /// <param name="nom">Nom mis à jour.</param>
        /// <param name="prenom">Prénom mis à jour.</param>
        /// <param name="mail">Mail mis à jour.</param>
        /// <param name="tel">Numéro de téléphone mis à jour.</param>
        /// <param name="idService">Identifiant du service mis à jour.</param>
        public void ModifPersonnel(Personnel personnel, string nom, string prenom, string mail, string tel, int idService)
        {
            personnel.Nom = nom;
            personnel.Prenom = prenom;
            personnel.Mail = mail;
            personnel.Tel = tel;
            personnel.IdService = idService;
            AccesDonnees.ModifPersonnel(personnel);
        }

        public void SupprPersonnel(Personnel personnel)
        {
            lesPersonnels.Remove(personnel);
            AccesDonnees.SupprPersonnel(personnel);
        }

        public bool AjoutAbsence(Personnel personnel, DateTime dateDebut, DateTime dateFin, int idMotif)
        {
            if(VerifieDateUnique(personnel, dateDebut))
            {
                Absence nvelleAbsence = new Absence(personnel, dateDebut, dateFin, idMotif);
                personnel.Absences.Add(nvelleAbsence);
                AccesDonnees.AjoutAbsence(nvelleAbsence);
                return true;
            }
            return false;

        }

        public bool ModifAbsence(Absence absence, DateTime nvelleDateDebut, DateTime nvelleDateFin, int nvelIdMotif)
        {
            if (VerifieDateUnique(absence.LePersonnel, nvelleDateDebut))
            {
                absence.DateDebut = nvelleDateDebut;
                absence.DateFin = nvelleDateFin;
                absence.Motif = nvelIdMotif;
                AccesDonnees.ModifAbence(absence);
                return true;
            }
            return false;
        }

        public void SupprAbsence(Personnel personnel, Absence abence)
        {
            personnel.Absences.Remove(abence);
            
        }

        private bool VerifieDateUnique(Personnel personnel, DateTime dateDebut)
        {
            foreach (Absence absence in personnel.Absences)
            {
                if (absence.DateDebut.Equals(dateDebut)) return false;
            }

            return true;
        }
    }
}
