using RetourPoo;
namespace Retour_test
{
    [TestClass]
    public class moto_test
    {
        Moteur moteur;
        Roue roues;
        int dureeVieKm;
        string style;
        int tailleReservoir;
        double distanceParcourue;
        int anneeDeProduction;
        int autonomieKm;
        private const string Expected = "Pour faire le tournant serré, vous avez dû incliner la moto.";

        Moto moto;

        [TestInitialize]

        public void Init()
        {
            moteur = new Moteur(1,2,3,4);
            roues = new Roue(2,4,2,5,'v',2,"michel");
            dureeVieKm = 45;
            style = "jean";
            tailleReservoir = 69;
            distanceParcourue = 0;
            anneeDeProduction = 2021;
            autonomieKm = 17;
            moto = new Moto(dureeVieKm,style,tailleReservoir,moteur,roues,"Red","dorcel","intrompable");
        }
        [TestCleanup]

        public void cleanup()
        {
            moteur = null;
            roues = null;
            dureeVieKm = 0;
            style = " ";
            tailleReservoir = 0;
            distanceParcourue = 0;
            anneeDeProduction = 0;
            autonomieKm = 0;
            moto = null;
        }

        [TestMethod]
        public void Moto_valeurCorrecte_Rouememevaleur()
        {
            Assert.AreEqual<int>(dureeVieKm, moto.DureeVieKm);
            Assert.AreEqual<string>(style, moto.Style);
            Assert.AreEqual<int>(tailleReservoir, moto.TailleReservoir);
            Assert.AreEqual<Moteur>(moteur, moto.Moteur);
          //  Assert.AreEqual<Roue>(roues, moto.Roues[0]);
            Assert.AreEqual<string>("Red", moto.Couleur);
            Assert.AreEqual<string>("dorcel", moto.Marque);
            Assert.AreEqual<string>("intrompable", moto.Modele);
            Assert.AreEqual<int>(anneeDeProduction, moto.AnneeDeProduction);
            Assert.AreEqual(autonomieKm, moto.AutonomieKm);
        }
        [TestMethod]
        //tournee serrer
        public void Moto_Afficher_TournerserrerMemeAffichage()
        {
            using (var tourne = new StringWriter())
            {
                Console.SetOut(tourne);
                moto.TournerSerrer();

                var result = tourne.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
        [TestMethod]
        //ajouter usure
        public void Moto_AjouterLusure_UsureSupperieur()
        {
            int ajouter = 8;
            Assert.AreEqual<double>(distanceParcourue, moto.DistanceParcourue);
            moto.AjouterUsure(ajouter);
            Assert.AreEqual<double>(distanceParcourue + ajouter, moto.DistanceParcourue);
        }
        [TestMethod]
        //diminuerPression
        public void Moto_diminuerPression_PressionInferieur()
        {

            Assert.AreEqual<int>(roues.Pression, moto.Roues[0].Pression);
            moto.DiminuerPression();
            Assert.AreEqual<double>(roues.Pression -1, moto.Roues[0].Pression);
        }
        [TestMethod]
        //ajouterp pression
        public void Moto_AjouterPression_Pressionsuperieur()
        {
            int pressionAjou = 35 - roues.Pression;
            Assert.AreEqual<int>(roues.Pression, moto.Roues[0].Pression);
            moto.AjouterPression();
            Assert.AreEqual<int>(roues.Pression + pressionAjou, moto.Roues[0].Pression);
        }
        [TestMethod]
        public void Moto_Faireleplein_valeur_supperieur()
        {
          string attendu = "Pour faire le tournant serré, vous avez dû incliner la moto.\r\nVous avez fait le plein !";

            moto.AjouterPression();
            using (var plein = new StringWriter())
            {
                Console.SetOut(plein);
                moto.FaireLePlein();
               
                var result = plein.ToString().Trim();

                Assert.AreEqual(attendu, result);

            }
        }
        public void Moto_Demarrer_AffichageCorecte()
        {

        }

    }
}
