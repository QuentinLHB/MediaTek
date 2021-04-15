﻿using System;
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
    /// <summary>
    /// Contrôleur de l'application.
    /// </summary>
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

        public void Authentification(string login, string pwd)
        {
            if (AccesDonnees.ControleAuthentification(login, pwd))
            {
                frmConnexion.Hide();
                lesPersonnels = GetPersonnels();
                frmPersonnel = new FrmPersonnel(this);
            }

            else frmConnexion.ErreurConnexion();
            
        }

        public List<Personnel> GetPersonnels()
        {
            return AccesDonnees.GetPersonnels();
        }

        /// <summary>
        /// Ajoute un nouveau personnel à la base de données, et l'affiche.
        /// </summary>
        /// <param name="nom">Nom du nouveau personnel.</param>
        /// <param name="prenom">Prénom du nouveau personnel</param>
        /// <param name="mail">Mail du nouveau personnel</param>
        /// <param name="tel">Numéro de téléphone du nouveau personnel</param>
        /// <param name="idService">Identifiant du service du nouveau personnel</param>
        public void AjoutPersonnel(string nom, string prenom, string mail, string tel, int idService)
        {                    
            Personnel nvoPersonnel = new Personnel(nom, prenom, tel, mail, idService);
            lesPersonnels.Add(nvoPersonnel);
            AccesDonnees.AjoutPersonnel(nvoPersonnel);
            nvoPersonnel.IdPersonnel = AccesDonnees.GetMaxIdPersonnel();
        }

        /// <summary>
        /// Modifie les informations d'un personnel dans la base données, et affichage de la modification.
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

        /// <summary>
        /// Supprime un personnel de la base de données, et son affichage.
        /// </summary>
        /// <param name="personnel"Personnel à supprimer.</param>
        public void SupprPersonnel(Personnel personnel)
        {
            AccesDonnees.SupprPersonnel(personnel);
            lesPersonnels.Remove(personnel);            
        }

        /// <summary>
        /// Ajoute une nouvelle absence à la base de données, et l'affiche.
        /// </summary>
        /// <param name="personnel">Personnel concerné par l'absence.</param>
        /// <param name="dateDebut">Date de début de l'absence.</param>
        /// <param name="dateFin">Date de fin de l'absence.</param>
        /// <param name="idMotif">Identifiant du motif de l'absence.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Modification d'une absence du personnel.
        /// </summary>
        /// <param name="absence">Absence concernée.</param>
        /// <param name="nvelleDateDebut">Nouvelle date de début.</param>
        /// <param name="nvelleDateFin">Nouvelle date de fin.</param>
        /// <param name="nvelIdMotif">Identifiant du nouveau motif.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Suppression d'une absence.
        /// </summary>
        /// <param name="personnel">Personnel concerné.</param>
        /// <param name="absence">Abence à supprimer.</param>
        public void SupprAbsence(Absence absence)
        {
            AccesDonnees.SupprAbsence(absence);
            absence.LePersonnel.Absences.Remove(absence);            
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
