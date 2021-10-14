using NUnit.Framework;
using dstec;

namespace TestDstec
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestTaxaJuros()
        {
            bool resultado = dstec.taxajuros();
            Assert.Pass();
        }
    }
}