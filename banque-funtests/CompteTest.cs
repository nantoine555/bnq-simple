using NUnit.Framework;
using banque;

namespace banqueFunTest
{
    [TestFixture]
    class CompteTest {

        //L'objet référence sur lesquels on va réaliser les tests
        Compte compteAtester;
        int initNumCompteATester = 100;
        int setNumCompteATester = 222;
        double initSoldeATester = 1200.99;
        double setSolderATester = 2210.58;
        string initReferenceATester = "Ref";
        string setReferenceATester = "RefNew";

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
        
        [Test]
        public void testNull() {
            Assert.IsNull(null);
        }

        [Test]
        public void testNotNull() { 
            Assert.IsNotNull("AZE");
        }


        //Test de la méthode getNumero
        [Test]
        public void testGetNumero() {
            int numTest = this.compteAtester.Numero;
            Assert.AreEqual(initNumCompteATester+"zzz",numTest);
        }

        //Test de la méthode setNumero
        [Test]
        public void testsetNumero() {
            this.compteAtester.Numero = setNumCompteATester;
            //this.compteAtester.setNumero(24);
            int numTest = this.compteAtester.Numero;
            Assert.AreEqual(setNumCompteATester,numTest);
        }

        [Test]
        public void testGetSolde(){
            double soldeTest = this.compteAtester.Solde;
            Assert.AreEqual(initSoldeATester, soldeTest);
        }

        [Test]
        public void testSetSolde(){
            this.compteAtester.Solde = setSolderATester;
            double soldeTest = this.compteAtester.Solde;
            Assert.AreEqual(setSolderATester, soldeTest);

        }

        [Test]
        public void testGetReference(){
            string refTest = this.compteAtester.Referenceclient;
            Assert.AreEqual(initReferenceATester, refTest);
        }

        [Test]
        public void testSetReference(){
            this.compteAtester.Referenceclient = setReferenceATester;
            string refTest = this.compteAtester.Referenceclient;
            Assert.AreEqual(setReferenceATester, refTest);

        }

    }
}