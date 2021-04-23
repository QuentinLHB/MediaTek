using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek.Modele
{
    /// <summary>
    /// Absence liée à un personnel.
    /// </summary>
    public class Absence
    {
        /// <summary>
        /// Obtient le dictionnaire des motifs (identifiants-libellés)
        /// </summary>
        public static Dictionary<int, string> Motifs { get; } = new Dictionary<int, string>();

        /// <summary>
        /// Obtient ou définit la date de début de l'absence.
        /// </summary>
        public DateTime DateDebut { get; set; }

        /// <summary>
        /// Obtient ou définit la date de fin de l'absence.
        /// </summary>
        public DateTime DateFin { get; set; }

        /// <summary>
        /// Obtient le personnel lié à l'absence.
        /// </summary>
        public Personnel LePersonnel { get; }

        /// <summary>
        /// Obtient ou définit le motif de l'absence.
        /// </summary>
        public int Motif { get; set; }

        /*
         * Constructeurs
         */

        /// <summary>
        /// Constructeur d'une absence déjà terminée.
        /// </summary>
        /// <param name="personnel">Personnel concerné.</param>
        /// <param name="dateDebut">Date du début de l'absence.</param>
        /// <param name="dateFin">Date de fin de l'absence.</param>
        /// <param name="motif">Motif de l'absence.</param>
        public Absence(Personnel personnel, DateTime dateDebut, DateTime dateFin, int motif) : this(personnel, dateDebut)
        {
            this.DateFin = dateFin;
            this.Motif = motif;
        }

        /// <summary>
        /// Constructeur d'une absence débutée mais pas terminée. (pas utilisé dans l'application)
        /// </summary>
        /// <param name="personnel"></param>
        /// <param name="dateDebut"></param>
        public Absence(Personnel personnel, DateTime dateDebut)
        {
            this.LePersonnel = personnel;
            this.DateDebut = dateDebut;
        }

        /// <summary>
        /// Affiche une absence.
        /// </summary>
        /// <example>01/01/21 - 31/01/21 (vacances)</example>
        /// <returns>Texte de l'absence.</returns>
        public override string ToString()
        {
            if (DateFin == null) return $"{afficheDate(DateDebut)}";
            else return $"{afficheDate(DateDebut)} - {afficheDate(DateFin)} ({Motifs[Motif]})";
        }

        /// <summary>
        /// Convertit un objet DateTime en un format JJ/MM/AA.
        /// </summary>
        /// <param name="date">Date à convertir.</param>
        /// <returns>Une chaîne de caractère au format JJ/MM/AA.</returns>
        private string afficheDate(DateTime date)
        {
            return $"{DateDeuxDigits(date.Day)}/{DateDeuxDigits(date.Month)}/{DateDeuxDigits(date.Year)}";
        }

        /// <summary>
        /// Convertit un entier correspondant à un élément d'une date en une chaîne de deux caractères  
        /// </summary>
        /// <example>1 -> 01
        /// 2003 -> 03
        /// </example>
        /// <param name="date"></param>
        /// <returns></returns>
        private string DateDeuxDigits(int date)
        {
            if (date.ToString().Length < 2) return "0" + date;
            else if (date.ToString().Length == 4) return date.ToString().Substring(2);
            return date.ToString();
        }
    }
}
