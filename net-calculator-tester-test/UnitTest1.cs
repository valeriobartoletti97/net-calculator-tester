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

        [Test]
        [TestCase(1.3f, 1.7f)]
        [TestCase(-1.3f, -1.7f)]
        [TestCase(1.3f, -1.7f)]
        public void TestSubstract(float num1, float num2)
        {
            var result = num1 - num2;
            Assert.AreEqual(Calculator.Substract(num1, num2), result);
        }

        [Test]
        [TestCase(12, 3)]
        [TestCase(-1.3f, 0)]
        [TestCase(1, -1)]
        public void TestMultiply(float num1, float num2)
        {
            var result = num1 * num2;
            Assert.AreEqual(Calculator.Multiply(num1, num2), result);
        }


        [Test]
        [TestCase(12, 3)]
        [TestCase(-1.3f, 0)]
        [TestCase(1, -1)]
        public void TestDivide(float num1, float num2)
        {
            if(num2 == 0)
            {
            Assert.Throws<System.ArgumentException>(() => { Calculator.Divide(num1, num2); },
           "Stai tentando di dividere per zero per zero");
            }
            else
            {
                var result = num1 * num2;
                Assert.AreEqual(Calculator.Multiply(num1, num2), result);
            }
        }
    }
}