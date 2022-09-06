using RetourPoo;

namespace Retour_test
{
    [TestClass]
    public class spyder_test
    {
        Moteur moteur;
        Roue roues;
        int dureeVieKm;
        int tailleReservoir;
        double distanceParcourue;
        private const string Expected = "Pour faire le tournant serré, vous avez simplement tourné la direction de la Spyder.";
        Spyder s;

        [TestInitialize]

        public void init()
        {
            moteur = new Moteur(1, 2, 3, 4);
            roues = new Roue(2, 4, 2, 5, 'v', 2, "michel");
            dureeVieKm = 45;
            tailleReservoir = 69;
            distanceParcourue = 0;
            s = new Spyder(dureeVieKm, tailleReservoir, moteur, roues, "Red", "dorcel", "intrompable");
        }

        [TestMethod]
        public void spyder_Afficher_TournerserrerMemeAffichage()
        {
            using (var tourne = new StringWriter())
            {
                Console.SetOut(tourne);
                s.TournerSerrer();

                var result = tourne.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}
