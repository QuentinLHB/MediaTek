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
    public class Personnel
    {

        /// <summary>
        /// Services.
        /// </summary>
        private static Dictionary<int, string> lesServices = new Dictionary<int, string>();
        public static Dictionary<int, string> Services { get => lesServices; }

        private int idPersonnel;
        public int IdPersonnel { get => idPersonnel; set => idPersonnel = value; }

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

        private List<Absence> lesAbsences = new List<Absence>();
        public List<Absence> Absences { get => lesAbsences; }

        /// <summary>
        /// Service occupé par le personnel.
        /// </summary>
        /// <returns></returns>
        private int idService;
        public int IdService { get => idService; set => idService = value; }
        public string Service { get => Services[idService]; }

        public Personnel(int idDeveloppeur, string nom, string prenom, string mail, string tel, int service) : this(nom, prenom, mail, tel, service)
        {
            this.idPersonnel = idDeveloppeur;            
        }

        public Personnel(string nom, string prenom, string mail, string tel, int service)
        {
            this.nom = nom.ToUpper();
            this.prenom = prenom;
            this.mail = mail;
            this.tel = tel;
            this.idService = service;
        }

        public override string ToString()
        {
            return $"{nom} {prenom} ({Service})";
        }
    }
}
