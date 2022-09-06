using RetourPoo;
namespace Retour_test
{
    [TestClass]
    public class test_Moteur
    {
        int taille;
        int nbCylindres;
        int puissanceChevauxVapeur;
        double consommationParKm;
        Moteur m;
        private const string Expected = "Vrooooom !";

        [TestInitialize]

        public void init()
        {
            taille = 100;
            nbCylindres = 6;
            puissanceChevauxVapeur = 200;
            consommationParKm = 1;
            m = new Moteur(taille, nbCylindres, puissanceChevauxVapeur, consommationParKm);
        }

        [TestCleanup]

        public void cleanup()
        {
            taille = 0;
            nbCylindres = 0;
            puissanceChevauxVapeur = 0;
            consommationParKm = 0;
            m = null;
        }

        [TestMethod]
        public void Moteur_valeurCorrecte_Moteurmemevaleur()
        {
            Assert.AreEqual<int>(taille, m.Taille);
            Assert.AreEqual<int>(nbCylindres, m.NbCylindres);
            Assert.AreEqual<int>(puissanceChevauxVapeur, m.PuissanceChevauxVapeur);
            Assert.AreEqual<double>(consommationParKm, m.ConsommationParKm);
        }

        [TestMethod]
        public void Moteur_Afficher_MoteurMemeAffichage()
        {
            using (var vrom = new StringWriter())
            {
                Console.SetOut(vrom);
                m.DemarrerMoteur();

                var result = vrom.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }



        }
    }
}
