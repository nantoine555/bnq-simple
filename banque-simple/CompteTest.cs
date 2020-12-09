using NUnit.Framework;

namespace banque
{
    [TestFixture]
    class CompteTest {
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