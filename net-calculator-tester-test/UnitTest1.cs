using net_calculator_tester;
namespace net_calculator_tester_test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1.3f , 1.7f)]
        [TestCase(-1.3f, -1.7f)]
        [TestCase(1.3f, -1.7f)]
        public void TestAdd(float num1, float num2)
        {
            var result = num1 + num2;
            Assert.AreEqual(Calculator.Add(num1, num2),result);
        }
    }
}