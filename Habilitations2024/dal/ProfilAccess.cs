using Habilitations2024.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habilitations2024.dal
{
    public class ProfilAccess
    {
        private readonly Access access = null;

        public ProfilAccess()
        {
            access = Access.GetInstance();
        }

        public List<Profil> GetLesProfils()
        {
            List<Profil> lesProfils = new List<Profil>();
            if(access.Manager != null)
            {
                string requete = "SELECT * FROM profil ORDER BY nom;";
                try
                {
                    List<Object[]> resultats = access.Manager.ReqSelect(requete);
                    if(resultats != null)
                    {
                        foreach (Object[] ligne in resultats)
                        {
                            Profil profil = new Profil((int)ligne[0], (string)ligne[1]);
                            lesProfils.Add(profil);
                        }
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Erreur lors de la récupération des profils : " + e.Message);
                    Environment.Exit(0);
                }
            }
            return lesProfils;
        }
    }
}
