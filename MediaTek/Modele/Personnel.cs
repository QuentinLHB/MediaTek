using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek.Modele
{
    /// <summary>
    /// Personnel de la médiathèque.
    /// </summary>
    class Personnel
    {

        /// <summary>
        /// Services.
        /// </summary>
        private static Dictionary<int, string> lesServices;

        /// <summary>
        /// Nom du personnel.
        /// </summary>
        private string nom;
        public string Nom { get => nom; set => nom = value; }

        /// <summary>
        /// Prénom du personnel.
        /// </summary>
        private string prenom;
        public string Prenom { get => prenom; set => prenom = value; }

        /// <summary>
        /// Adresse mail du personnel.
        /// </summary>
        private string mail;
        public string Mail { get => mail; set => mail = value; }

        /// <summary>
        /// Numéro de téléphone du personnel.
        /// </summary>
        private string tel;

        public string Tel { get => tel; set => tel = value; }

        /// <summary>
        /// Service occupé par le personnel.
        /// </summary>
        /// <returns></returns>
        private string service;
        public string Service { get => service; set => service = value; }

        public Personnel(string nom, string prenom, string mail, string tel, string service)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.mail = mail;
            this.tel = tel;
            this.service = service;
        }
    }
}
