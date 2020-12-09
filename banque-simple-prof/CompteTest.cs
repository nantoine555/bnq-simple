using NUnit.Framework;

namespace banque {

    [TestFixture]
    public class CompteTest {

        // 1. Prévoir la création de l'objet.
        // Ici il est important que l'objet soit créé avant chaque test (pour
        // être sur d'exécuter les tests avec un objet "propre".
        private Compte compte;

        [SetUp]
        public void setUp() {
            compte = new Compte(568942, 1000.00, "rdupont0001");
        }

        [Test]
        public void testFake() {
            int a = 0;
            Assert.AreEqual(0, a);
        }

        [Test]
        public void testGetNumero() {
            int numero = compte.Numero;
            Assert.AreEqual(568942, numero);
        }

        [Test]
        public void testSetNumero() {
            compte.Numero = 965785;
            Assert.AreEqual(965785, compte.Numero);
        }

        [Test]
        public void testGetSolde() {
            double solde = compte.Solde;
            Assert.AreEqual(1000.00, solde);            
        }

        [Test]
        public void testSetSolde() {
            compte.Solde = 555.00;
            Assert.AreEqual(555.00, compte.Solde);            
        }

        [Test]
        public void testGetReferenceclient() {
            string referenceclient = compte.Referenceclient;
            Assert.AreEqual("rdupont0001", referenceclient);
        }

        [Test]
        public void testSetReferenceclient() {
            compte.Referenceclient = "smartin0002";
            Assert.AreEqual("smartin0002", compte.Referenceclient);
        }

    }

}