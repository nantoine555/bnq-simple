using NUnit.Framework;

namespace banque
{
    [TestFixture]
    class CompteTest {

        //L'objet référence sur lesquels on va réaliser les tests
        Compte compteAtester;
        int initNumCompteATester = 0;
        int setNumCompteATester = 1;

        //Prévoir la création de l'objet avant chaque test
        [SetUp]
        public void Setup() {
            this.compteAtester = new Compte(initNumCompteATester,120.99,"ref");
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

        //Test de la méthode getnuméro
        [Test]
        public void testGetNumero() {
            int numTest = this.compteAtester.getNumero();
            Assert.AreEqual(initNumCompteATester,numTest);
        }

        //Test de la méthode setnuméro
        [Test]
        public void testsetNumero() {
            this.compteAtester.setNumero(setNumCompteATester);
            //this.compteAtester.setNumero(24);
            int numTest = this.compteAtester.getNumero();
            Assert.AreEqual(setNumCompteATester,numTest);
        }

    }
}