using NUnit.Framework;

namespace banque
{
    [TestFixture]
    class CompteTest {

        //L'objet référence sur lesquels on va réaliser les tests
        Compte compteAtester;
        int initNumCompteATester = 0;
        int setNumCompteATester = 1;
        double initSoldeATester = 120.99;
        string initReferenceATester = "Ref";

        //Prévoir la création de l'objet avant chaque test
        [SetUp]
        public void Setup() {
            this.compteAtester = new Compte(initNumCompteATester, initSoldeATester, initReferenceATester);
        }

        //Cleanup après chaque test
        [TearDown]
        public void TearDown(){
            this.compteAtester = null;
        }


// Les tests...
        [Test]
        public void testFalse() {
            Assert.IsFalse(false);
        }

        [Test]
        public void testTrue() {
            Assert.IsTrue(true);
        }

        //Test de la méthode getNumero
        [Test]
        public void testGetNumero() {
            int numTest = this.compteAtester.getNumero();
            Assert.AreEqual(initNumCompteATester,numTest);
        }

        //Test de la méthode setNumero
        [Test]
        public void testsetNumero() {
            this.compteAtester.setNumero(setNumCompteATester);
            //this.compteAtester.setNumero(24);
            int numTest = this.compteAtester.getNumero();
            Assert.AreEqual(setNumCompteATester,numTest);
        }

    }
}