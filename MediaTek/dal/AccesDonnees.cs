using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaTek.Connexion;
using MediaTek.Modele;

namespace MediaTek.dal
{
    /// <summary>
    /// Classe effectuant les requêtes SQL nécessaires à l'extraction et à la mise à jour de la base de données.
    /// </summary>
    public class AccesDonnees
    {
        /// <summary>
        /// chaine de connexion à la bdd
        /// </summary>
        private static string connectionString = "server=localhost;user id=admin;password=mdpadmin;database=mediatek";

        /// <summary>
        /// Controle si l'utillisateur a le droit de se connecter (login et pwd)
        /// </summary>
        /// <param name="login">Identifiant entré</param>
        /// <param name="pwd">Mot  de passe entré.</param>
        /// <returns></returns>
        public static Boolean ControleAuthentification(string login, string pwd)
        {
            string req = "select * from responsable ";
            req += "where login=@login and pwd=SHA2(@pwd, 256)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@login", login);
            parameters.Add("@pwd", pwd);
            ConnexionBDD curs = ConnexionBDD.GetInstance(connectionString);
            curs.ReqSelect(req, parameters);
            if (curs.Read())
            {
                curs.Close();
                return true;
            }
            else
            {
                curs.Close();
                return false;
            }           
        }

        /// <summary>
        /// Obtient la liste du personnel depuis la base de données.
        /// </summary>
        /// <returns>Liste du personnel.</returns>
        public static List<Personnel> GetPersonnels()
        {
            SetServices();
            List<Personnel> personnels = new List<Personnel>();
            string req = "select * from personnel join service using (idservice)";
            ConnexionBDD curseur = ConnexionBDD.GetInstance(connectionString);
            curseur.ReqSelect(req, null);

            while (curseur.Read())
            {
                personnels.Add(new Personnel((int)curseur.Field("idpersonnel"), (string)curseur.Field("nom"),
                    (string)curseur.Field("prenom"), (string)curseur.Field("mail"), (string)curseur.Field("tel"), (int)curseur.Field("idService")));
            }
            curseur.Close();

            SetMotifs();
            foreach (Personnel personnel in personnels)
            {
                SetAbsences(personnel);
            }
            return personnels;
        }

        /// <summary>
        /// Remplit les absences d'un personnel.
        /// </summary>
        /// <param name="personnel">Personnel concerné</param>
        public static void SetAbsences(Personnel personnel)
        {            
            string req = "select p.idpersonnel, a.datedebut, a.datefin, a.idmotif from personnel p JOIN absence a USING (idpersonnel)";
            req += " where p.idpersonnel = @idpersonnel";
            req += " order by datedebut DESC";
            ConnexionBDD curseur = ConnexionBDD.GetInstance(connectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.IdPersonnel);
            curseur.ReqSelect(req, parameters);
            while (curseur.Read())
            {
                personnel.Absences.Add(new Absence(personnel, (DateTime)curseur.Field("datedebut"), (DateTime)curseur.Field("datefin"), (int)curseur.Field("idmotif")));
            }
            curseur.Close();
        }

        /// <summary>
        /// Remplit le dictionnaire des services s'il n'a pas déjà été initialisé.
        /// </summary>
        private static void SetServices()
        {
            if (Personnel.Services.Count == 0 )
            {
                string req = "select * from service";
                ConnexionBDD curseur = ConnexionBDD.GetInstance(connectionString);
                curseur.ReqSelect(req, null);
                while (curseur.Read())
                {
                    Personnel.Services.Add((int)curseur.Field("idservice"), (string)curseur.Field("nom"));
                }
                curseur.Close();
            }

        }

        /// <summary>
        /// Remplit le dictionnaire des motifs s'il n'a pas déjà été initialisé.
        /// </summary>
        private static void SetMotifs()
        {
            if (Absence.Motifs.Count == 0)
            {
                string req = "select * from motif";
                ConnexionBDD curseur = ConnexionBDD.GetInstance(connectionString);
                curseur.ReqSelect(req, null);
                while (curseur.Read())
                {
                    Absence.Motifs.Add((int)curseur.Field("idmotif"), (string)curseur.Field("libelle"));
                }
                curseur.Close();
            }
        }

        /// <summary>
        /// Ajoute un personnel à la base de données.
        /// </summary>
        /// <param name="idPersonnel"></param>
        /// <param name="idService"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        public static void AjoutPersonnel(Personnel personnel)
        {
            string req = "insert into personnel(idservice, nom, prenom, tel, mail)";
            req += " values (@idservice, @nom, @prenom, @tel, @mail)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idservice", personnel.IdService);
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            ConnexionBDD curseur = ConnexionBDD.GetInstance(connectionString);
            curseur.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Modifie un personnel dans la base de données.
        /// </summary>
        /// <param name="idPersonnel">Identifiant du personnel à modifier.</param>
        /// <param name="idService"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        public static void ModifPersonnel(Personnel personnel)
        {
            string req = "update personnel";
            req += " set idservice = @idservice, nom = @nom, prenom = @prenom, tel = @tel, mail = @mail";
            req += " where idpersonnel = @idpersonnel";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.IdPersonnel);
            parameters.Add("@idservice", personnel.IdService);
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Supprime un personnel de la base de données.
        /// </summary>
        /// <param name="personnel">Personnel concerné.</param>
        public static void SupprPersonnel(Personnel personnel)
        {
            string req = "delete from personnel where idpersonnel = @idpersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.IdPersonnel);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Obtient l'identifiant de personnel le plus grand.
        /// </summary>
        /// <returns>Identifiant maximum de la table "personnel".</returns>
        public static int GetMaxIdPersonnel()
        {
            string req = "select max(idpersonnel) from personnel";
            ConnexionBDD curseur = ConnexionBDD.GetInstance(connectionString);
            curseur.ReqSelect(req, null);
            int max = -1;
            if (curseur.Read())
            {
                max = (int)curseur.Field("max(idpersonnel)");
            }
            curseur.Close();
            return max;
        }

        /// <summary>
        /// Ajoute une absence à la base de données.
        /// </summary>
        /// <param name="absence">Absence à ajouter.</param>
        public static void AjoutAbsence(Absence absence)
        {
            string req = "insert into absence(idpersonnel, datedebut, datefin, idmotif)";
            req += " values (@idpersonnel, @datedebut, @datefin, @idmotif)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", absence.LePersonnel.IdPersonnel);
            parameters.Add("@datedebut", absence.DateDebut);
            parameters.Add("@datefin", absence.DateFin);
            parameters.Add("@idmotif", absence.Motif);
            ConnexionBDD curseur = ConnexionBDD.GetInstance(connectionString);
            curseur.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Modifie une absence dans la base de données.
        /// </summary>
        /// <param name="absence">Absence à modifier.</param>
        public static void ModifAbence(Absence absence)
        {
            string req = "update absence";
            req += " set datedebut = @datedebut, datefin = @datefin, idmotif = @idmotif";
            req += " where idpersonnel = @idpersonnel and datedebut = @datedebut";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", absence.LePersonnel.IdPersonnel);
            parameters.Add("@datedebut", absence.DateDebut);
            parameters.Add("@datefin", absence.DateFin);
            parameters.Add("@idmotif", absence.Motif);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Supprime une absence.
        /// </summary>
        /// <param name="absence">Absence à supprimer.</param>
        public static void SupprAbsence(Absence absence)
        {
            string req = "delete from absence where idpersonnel = @idpersonnel and datedebut = @datedebut;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", absence.LePersonnel.IdPersonnel);
            parameters.Add("@datedebut", absence.DateDebut);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }
    }
}
