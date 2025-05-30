using Habilitations2024.dal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Habilitations2024.UnitTest
{
    [TestClass]
    public class GetLesDeveloppeurs_testFiltres
    {
        private DeveloppeurAccess developpeurAccess;
        private ProfilAccess profilAccess;

        [TestInitialize]
        public void Init()
        {
            developpeurAccess = new DeveloppeurAccess();
            profilAccess = new ProfilAccess();
        }

        [TestMethod]
        public void TestNumDevByProfil()
        {
            var profils = profilAccess.GetLesProfils();
            var allDeveloppeurs = developpeurAccess.GetLesDeveloppeurs();

            foreach (var profil in profils)
            {
                var numDevByProfil = developpeurAccess.GetNumDevByProfile(profil);
                var developpeurs = developpeurAccess.GetLesDeveloppeurs(profil.Nom);

                Assert.AreEqual(
                    numDevByProfil,
                    developpeurs.Count,
                    $"Le nombre de développeurs pour le profil {profil.Nom} ne correspond pas : Attendu {numDevByProfil}, obtenu {developpeurs.Count}"
                );

                // Vérifie que tous les développeurs retournés ont bien le profil demandé
                Assert.IsTrue(
                    developpeurs.All(d => d.Profil.Nom == profil.Nom),
                    $"Certains développeurs retournés n'ont pas le profil {profil.Nom}"
                );
            }
        }
        // Test unitaire pour vérifier que la méthode GetLesDeveloppeurs retourne tous les développeurs si aucun filtre n'est appliqué
        [TestMethod]
        public void TestGetLesDeveloppeursWithoutFilter()
        {
            var allDeveloppeurs = developpeurAccess.GetLesDeveloppeurs(" ");
            var expectedCount = developpeurAccess.GetLesDeveloppeurs().Count;
            Assert.AreEqual(expectedCount, allDeveloppeurs.Count, "Le nombre de développeurs retournés ne correspond pas au nombre attendu sans filtre.");
        }
    }
}
