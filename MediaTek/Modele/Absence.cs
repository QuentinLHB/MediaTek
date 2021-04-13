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
    class Absence
    {

        private static Dictionary<int, string> lesMotifs;

        /// <summary>
        /// Début de l'absence.
        /// </summary>
        private DateTime dateDebut;
        public DateTime DateDebut { get => dateDebut; set => dateDebut = value; }

        /// <summary>
        /// Fin de l'absence.
        /// </summary>
        private DateTime dateFin;
        public DateTime DateFin { get => dateFin; set => dateFin = value; }

        /// <summary>
        /// Personnel concerné.
        /// </summary>
        private Personnel personnel;
        public Personnel LePersonnel { get => personnel; }


        /// <summary>
        /// Motif de l'absence.
        /// </summary>
        private string motif;
        public string Motif { get => motif; set => motif = value; }

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
        public Absence(Personnel personnel, DateTime dateDebut, DateTime dateFin, string motif) : this(personnel, dateDebut)
        {
            this.dateFin = dateFin;
            this.motif = motif;
        }

        /// <summary>
        /// Constructeur d'une absence débutée mais pas terminée.
        /// </summary>
        /// <param name="personnel"></param>
        /// <param name="dateDebut"></param>
        public Absence(Personnel personnel, DateTime dateDebut)
        {
            this.personnel = personnel;
            this.dateDebut = dateDebut;

        }
    }
}
