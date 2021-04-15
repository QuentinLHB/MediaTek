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
        /// Dictionnaire des services.
        /// </summary>
        private static Dictionary<int, string> lesServices = new Dictionary<int, string>();
        /// <summary>
        /// Obtient le dictionnaire des services.
        /// </summary>
        public static Dictionary<int, string> Services { get => lesServices; }

        /// <summary>
        /// Identifiant du personnel.
        /// </summary>
        private int idPersonnel;
        /// <summary>
        /// Obtient ou définit l'identifiant du personnel.
        /// </summary>
        public int IdPersonnel { get => idPersonnel; set => idPersonnel = value; }

        /// <summary>
        /// Nom du personnel.
        /// </summary>
        private string nom;
        /// <summary>
        /// Obtient ou définit le nom du personnel.
        /// </summary>
        public string Nom { get => nom; set => nom = value; }

        /// <summary>
        /// Prénom du personnel.
        /// </summary>
        private string prenom;
        /// <summary>
        /// Obtient ou définit le prénom du personnel.
        /// </summary>
        public string Prenom { get => prenom; set => prenom = value; }

        /// <summary>
        /// Adresse mail du personnel.
        /// </summary>
        private string mail;
        /// <summary>
        /// Obtient ou définit le mail du personnel.
        /// </summary>
        public string Mail { get => mail; set => mail = value; }

        /// <summary>
        /// Numéro de téléphone du personnel.
        /// </summary>
        private string tel;
        /// <summary>
        /// Obtient ou définit le numéro de téléphone du personnel.
        /// </summary>
        public string Tel { get => tel; set => tel = value; }

        /// <summary>
        /// Liste des absences du personnel.
        /// </summary>
        private List<Absence> lesAbsences = new List<Absence>();
        /// <summary>
        /// Obtient la liste des absences du personnel.
        /// </summary>
        public List<Absence> Absences { get => lesAbsences; }

        /// <summary>
        /// Service occupé par le personnel.
        /// </summary>
        /// <returns></returns>
        private int idService;
        /// <summary>
        /// Obtient ou définit l'identifiant du service du personnel.
        /// </summary>
        public int IdService { get => idService; set => idService = value; }
        /// <summary>
        /// Obtient le nom du service du personnel.
        /// </summary>
        public string Service { get => Services[idService]; }

        /// <summary>
        /// Constructeur avec toutes les informatons.
        /// </summary>
        /// <param name="idDeveloppeur"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="mail"></param>
        /// <param name="tel"></param>
        /// <param name="service">Identifiant du service du personnel.</param>
        public Personnel(int idDeveloppeur, string nom, string prenom, string mail, string tel, int service) : this(nom, prenom, mail, tel, service)
        {
            this.idPersonnel = idDeveloppeur;            
        }

        /// <summary>
        /// Constructeur avec identifiant inconnu.
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="mail"></param>
        /// <param name="tel"></param>
        /// <param name="service">Identifiant du service du personnel.</param>
        public Personnel(string nom, string prenom, string mail, string tel, int service)
        {
            this.nom = nom.ToUpper();
            this.prenom = prenom;
            this.mail = mail;
            this.tel = tel;
            this.idService = service;
        }

        /// <summary>
        /// Affiche un personnel.
        /// </summary>
        /// <returns>Le personnel au format Nom Prénom (Service)</returns>
        public override string ToString()
        {
            return $"{nom} {prenom} ({Service})";
        }
    }
}
