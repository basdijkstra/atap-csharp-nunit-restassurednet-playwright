using NUnit.Framework;

namespace ATAPNUnitRestAssuredNetPlaywright.UnitTests
{
    [TestFixture]
    public class ExampleTests
    {
        [Test]
        public void Add2and2_CheckResult_ShouldBe4()
        {
            int result = 2 + 2;

            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Add3and5_CheckResult_ShouldBe8()
        {
            int result = 3 + 5;

            Assert.That(result, Is.EqualTo(7));
        }
    }
}
