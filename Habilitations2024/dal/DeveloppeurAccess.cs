using Habilitations2024.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habilitations2024.dal
{
    public class DeveloppeurAccess
    {
        private readonly Access access = null;

        public DeveloppeurAccess()
        {
            access = Access.GetInstance();
        }

        public List<Developpeur> GetLesDeveloppeurs()
        {
            List<Developpeur> lesDeveloppeurs = new List<Developpeur>();
            if (access.Manager != null)
            {
                string requete = "SELECT d.iddeveloppeur as iddeveloppeur, d.nom as nom, d.prenom as prenom, d.tel as tel, d.mail as mail, p.idprofil as idprofil, p.nom as profil ";
                requete += "FROM developpeur d join profil p on (d.idprofil = p.idprofil) ";
                requete += "ORDER BY nom, prenom;";

                try
                {
                    List<Object[]> resultats = access.Manager.ReqSelect(requete);
                    if (resultats != null)
                    {
                        foreach (Object[] resultat in resultats)
                        {
                            Profil profil = new Profil((int)resultat[5], (string)resultat[6]);
                            Developpeur developpeur = new Developpeur((int)resultat[0], (string)resultat[1], (string)resultat[2], (string)resultat[3], (string)resultat[4], profil);
                            lesDeveloppeurs.Add(developpeur);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erreur lors de la récupération des développeurs : " + e.Message);
                    Environment.Exit(0);
                }
            }
            return lesDeveloppeurs;
        }

        public void DelDeveloppeur(Developpeur developpeur)
        {
            if (access.Manager != null)
            {
                string requete = "DELETE FROM developpeur WHERE iddeveloppeur = @iddeveloppeur;";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@iddeveloppeur", developpeur.Iddeveloppeur }
                };
                try
                {
                    access.Manager.ReqUpdate(requete, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erreur lors de la suppression du développeur : " + e.Message);
                    Environment.Exit(0);
                }
            }
        }

        public void AddDeveloppeur(Developpeur developpeur)
        {
            if (access.Manager != null)
            {
                string requete = "INSERT INTO developpeur (nom, prenom, tel, mail, pwd, idprofil) ";
                requete += "VALUES (@nom, @prenom, @tel, @mail, SHA2(@pwd, 256), @idprofil);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@nom", developpeur.Nom);
                parameters.Add("@prenom", developpeur.Prenom);
                parameters.Add("@tel", developpeur.Tel);
                parameters.Add("@mail", developpeur.Mail);
                parameters.Add("@pwd", developpeur.Nom);
                parameters.Add("@idprofil", developpeur.Profil.Idprofil);

                try
                {
                    access.Manager.ReqUpdate(requete, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erreur lors de l'ajout du développeur : " + e.Message);
                    Environment.Exit(0);
                }
            }
        }

        public void UpdateDeveloppeur(Developpeur developpeur)
        {
            if (access.Manager != null)
            {
                string requete = "UPDATE developpeur SET nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idprofil = @idprofil ";
                requete += "WHERE iddeveloppeur = @iddeveloppeur;";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@iddeveloppeur", developpeur.Iddeveloppeur },
                    { "@nom", developpeur.Nom },
                    { "@prenom", developpeur.Prenom },
                    { "@tel", developpeur.Tel },
                    { "@mail", developpeur.Mail },
                    //{ "@pwd", developpeur.Pwd },
                    { "@idprofil", developpeur.Profil.Idprofil }
                };
                try
                {
                    access.Manager.ReqUpdate(requete, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erreur lors de la mise à jour du développeur : " + e.Message);
                    Environment.Exit(0);
                }
            }
        }

        public void UpdatePwd(Developpeur developpeur)
        {
            if (access.Manager != null)
            {
                string requete = "UPDATE developpeur SET pwd = SHA2(@pwd, 256) WHERE iddeveloppeur = @iddeveloppeur;";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@iddeveloppeur", developpeur.Iddeveloppeur },
                    { "@pwd", developpeur.Pwd }
                };
                try
                {
                    access.Manager.ReqUpdate(requete, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erreur lors de la mise à jour du mot de passe du développeur : " + e.Message);
                    Environment.Exit(0);
                }
            }
        }

        public bool ControleAuthentification(Admin admin)
        {
            if (access.Manager != null)
            {
                string req = "select * from developpeur d join profil p on d.idprofil=p.idprofil ";
                req += "where d.nom=@nom and d.prenom=@prenom and pwd=SHA2(@pwd, 256) and p.nom='admin';";
                var parameters = new Dictionary<string, object>
                {
                    { "@nom", admin.Nom },
                    { "@prenom", admin.Prenom },
                    { "@pwd", admin.Pwd }
                };
                try
                {
                    List<Object[]> resultats = access.Manager.ReqSelect(req, parameters);

                    if (resultats != null)
                    {
                        return (resultats.Count > 0);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erreur lors de la vérification des droits : " + e.Message);
                    Environment.Exit(0);
                }
                return false;
            }
            return false;
        }
    }
}
