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
        /// Obtient le dictionnaire des services.
        /// </summary>
        public static Dictionary<int, string> Services { get; } = new Dictionary<int, string>();

        /// <summary>
        /// Obtient ou définit l'identifiant du personnel.
        /// </summary>
        public int IdPersonnel { get; }

        /// <summary>
        /// Obtient ou définit le nom du personnel.
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Obtient ou définit le prénom du personnel.
        /// </summary>
        public string Prenom { get; set; }

        /// <summary>
        /// Obtient ou définit le mail du personnel.
        /// </summary>
        public string Mail { get; set; }

        /// <summary>
        /// Obtient ou définit le numéro de téléphone du personnel.
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// Obtient la liste des absences du personnel.
        /// </summary>
        public List<Absence> Absences { get; private set; } = new List<Absence>();

        /// <summary>
        /// Obtient ou définit l'identifiant du service du personnel.
        /// </summary>
        public int IdService { get; set; }
        /// <summary>
        /// Obtient le nom du service du personnel.
        /// </summary>
        public string Service { get => Services[IdService]; }

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
            this.IdPersonnel = idDeveloppeur;            
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
            this.Nom = nom.ToUpper();
            this.Prenom = prenom;
            this.Mail = mail;
            this.Tel = tel;
            this.IdService = service;
        }

        /// <summary>
        /// Affiche un personnel.
        /// </summary>
        /// <returns>Le personnel au format Nom Prénom (Service)</returns>
        public override string ToString()
        {
            return $"{Nom} {Prenom} ({Service})";
        }

        public void TrieAbsences()
        {
            Absences = Absences.OrderByDescending(o => o.DateDebut).ToList();
        }
    }
}
