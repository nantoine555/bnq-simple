using NUnit.Framework;

namespace banque
{
    [TestFixture]
    class CompteTest {

        //L'objet référence sur lesquels on va réaliser les tests
        Compte compteAtester;

        //Prévoir la création de l'objet avant chaque test
        [SetUp]
        public void Setup() {
            this.compteAtester = new Compte();
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

    }
}