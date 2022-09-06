using test_unitaire;
namespace test_unitaire_test
{
    [TestClass]
    public class note_test
    {
        double pond = 0;
        double score = 3;
        Note n;

        [TestInitialize]

        public void init()
        {
            double pond = 0;
            double score = 3;
            n = new Note(pond, score);
        }

        [TestCleanup]

        public void cleanup()
        {
            pond = 0;
            score = 0;
            n = null;
        }

        [TestMethod]
        public void Note_valeurCorrecte_Notememevaleur()
        {
            Assert.AreEqual<double>(pond, n.Ponderation);
            Assert.AreEqual<double>(score, n.Score);

        }

        [TestMethod]
        public void ValeurCorrecte_valeurCorrecte_ScoreFoisPond()
        {
            double ValeurReel;

            ValeurReel = n.ValeurReelle();

            Assert.AreEqual<double>(pond * score, ValeurReel);

        }
    }
}