using libCptBq;
namespace superieur
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arranger
         
            Compte c1 = new Compte(105, "toto", 498, -200);
            Compte c2 = new Compte(110, "tata", 350, -200);

            // Agir 
            bool attendu = c1.Superieur(c2);


            // Auditer




            Assert.IsTrue(attendu);
        }
    }
}