using RetourPoo;
namespace Retour_test
{
    [TestClass]
    public class test_Roue
    {
        int largeur = 200;
        int pourcentageHauteur = 45;
        int diametreJante = 16;
        int indiceCharge = 90;
        char indiceVitesse = 'V';
        int pression = 30;
        string type = "Été";
        Roue r;

        [TestInitialize]

        public void init()
        {
            largeur = 200;
            pourcentageHauteur = 45;
            diametreJante = 16;
            indiceCharge = 90;
            indiceVitesse = 'V';
            pression = 30;
            type = "Été";
            r = new Roue(largeur,pourcentageHauteur,diametreJante,indiceCharge,indiceVitesse,pression,type);
        }

        [TestCleanup]

        public void cleanup()
        {
            largeur = 0;
            pourcentageHauteur = 0;
            diametreJante = 0;
            indiceCharge = 0;
            indiceVitesse = ' ';
            pression = 0;
            type = " ";
            r = null;
        }

        [TestMethod]
        public void Roue_valeurCorrecte_Rouememevaleur()
        {
            Assert.AreEqual<int>(largeur, r.Largeur);
            Assert.AreEqual<int>(pourcentageHauteur, r.PourcentageHauteur);
            Assert.AreEqual<int>(diametreJante, r.DiametreJante);
            Assert.AreEqual<int>(indiceCharge, r.IndiceCharge);
            Assert.AreEqual<char>(indiceVitesse, r.IndiceVitesse);
            Assert.AreEqual<int>(pression, r.Pression);
            Assert.AreEqual<string>(type, r.Type);
        }

        [TestMethod]
        public void Roue_valeurajouter_GonflerAjouetervaleur()
        {
            int ajouter = 8;
            Assert.AreEqual<int>(pression, r.Pression);
            r.GonflerPneu(ajouter);     
            Assert.AreEqual<int>(pression + ajouter, r.Pression);
        }

        [TestMethod]
        public void Roue_CopierRoue_RoueMemeValeur()
        {
            Roue roue = new Roue(largeur, pourcentageHauteur, diametreJante, indiceCharge, indiceVitesse, pression, type);

            Assert.AreEqual<int>(roue.Largeur, r.Largeur);
            Assert.AreEqual<int>(roue.PourcentageHauteur, r.PourcentageHauteur);
            Assert.AreEqual<int>(roue.DiametreJante, r.DiametreJante);
            Assert.AreEqual<int>(roue.IndiceCharge, r.IndiceCharge);
            Assert.AreEqual<char>(roue.IndiceVitesse, r.IndiceVitesse);
            Assert.AreEqual<int>(roue.Pression, r.Pression);
            Assert.AreEqual<string>(roue.Type, r.Type);
        }
    }
}