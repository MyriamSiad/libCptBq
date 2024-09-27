using libCptBq;
namespace transferer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double attendu = 550;
            //Arranger

            Compte c1 = new Compte(105, "toto", 498, -200);
            Compte c2 = new Compte(110, "tata", 350, -200);

            // Agir 
            c1.Transferer(200, c2);
            double actuel = c2.getSolde();


            // Auditer




            Assert.AreEqual(attendu,actuel, 0.001,"Account not debited");
        }
    }
}