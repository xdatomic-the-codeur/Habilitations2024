using Habilitations2024.model;
using Habilitations2024.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habilitations2024.controller
{
    public class FrmHabilitationsController
    {
        private readonly DeveloppeurAccess developpeurAccess;
        private readonly ProfilAccess profilAccess;

        public FrmHabilitationsController()
        {
            developpeurAccess = new DeveloppeurAccess();
            profilAccess = new ProfilAccess();
        }

        public List<Developpeur> GetLesDeveloppeurs(string profilName = null)
        {
            return developpeurAccess.GetLesDeveloppeurs(profilName);
        }

        public List<Profil> GetLesProfils()
        {
            return profilAccess.GetLesProfils();
        }

        public void DelDeveloppeur(Developpeur developpeur)
        {
            developpeurAccess.DelDeveloppeur(developpeur);
        }

        public void AddDeveloppeur(Developpeur developpeur)
        {
            developpeurAccess.AddDeveloppeur(developpeur);
        }

        public void UpdateDeveloppeur(Developpeur developpeur)
        {
            developpeurAccess.UpdateDeveloppeur(developpeur);
        }

        public void UpdatePwd(Developpeur developpeur)
        {
            developpeurAccess.UpdatePwd(developpeur);
        }
    }
}
