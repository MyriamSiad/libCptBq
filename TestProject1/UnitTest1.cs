using libCptBq;
using System.Numerics;


namespace superieur 
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arranger
            double attendu = 398;
            Compte c1 = new Compte(105, "toto", 498, -200);
            Compte c2 = new Compte(110, "tata", 350, -200);

            // Agir 
            c1.Debiter(100);


            // Aduiter

            double actuel = c1.getSolde();


            Assert.AreEqual(attendu, actuel, 0.001, "Account not debited correctly");

        }
    }
}