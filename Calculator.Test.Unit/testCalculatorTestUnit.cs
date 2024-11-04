using calculator;
namespace testCalculator.Test.Unit
{
    [TestFixture]
    public class testCalculatorTestUnit
    {
        private Calculator calc;
        private double _testval1;
        private double _testval2;
        private double _testval3;
        private double _testval4;
        private double _testval5;
        private double _testval6;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
            _testval1 = 4;
            _testval2 = 5.2;
            _testval3 = 72.4; 
            _testval4 = 6.2; 
            _testval5 = -3.6; 
            _testval6 = -2.5;
        }

        [Test]
        public void TestAdd()
        {
            Assert.That(calc.Add(_testval1,_testval2), Is.EqualTo(_testval1+_testval2));
            Assert.That(calc.Add(_testval3,_testval4), Is.EqualTo(_testval3+_testval4));
            Assert.That(calc.Add(_testval5,_testval6), Is.EqualTo(_testval5+_testval6));
        }

        [Test]
        public void TestSubtract()
        {
            double result = calc.Substract(2, 10);
            Assert.That(result, Is.EqualTo(-8));
            
            Assert.That(calc.Substract(_testval1,_testval2), Is.EqualTo(_testval1-_testval2));
            Assert.That(calc.Substract(_testval3,_testval4), Is.EqualTo(_testval3-_testval4));
            Assert.That(calc.Substract(_testval5,_testval6), Is.EqualTo(_testval5-_testval6));
        }

        [Test]
        public void TestMultiply()
        {
            Assert.That(calc.Multiply(_testval1,_testval2), Is.EqualTo(_testval1*_testval2).Within(0.05));
            Assert.That(calc.Multiply(_testval3,_testval4), Is.EqualTo(_testval3*_testval4).Within(0.05));
            Assert.That(calc.Multiply(_testval5,_testval6), Is.EqualTo(_testval5*_testval6).Within(0.05));
            
        }

        [Test]
        public void TestDivide()
        {
            Assert.That(calc.Divide(_testval1,_testval2), Is.EqualTo(_testval1/_testval2).Within(0.05));
            Assert.That(calc.Divide(_testval3,_testval4), Is.EqualTo(_testval3/_testval4).Within(0.05));
            Assert.That(calc.Divide(_testval5,_testval6), Is.EqualTo(_testval5/_testval6).Within(0.05));
        }

        [Test]
        
        public void TestDivideByZero()
        {
            Assert.Throws<DivideByZeroException>(() => calc.Divide(15, 0));
        }
        [Test]
        public void TestSquareRoot()
        {
            Assert.That(calc.SquareRoot(_testval1), Is.EqualTo(Math.Sqrt(_testval1)).Within(0.05));
            Assert.That(calc.SquareRoot(_testval2), Is.EqualTo(Math.Sqrt(_testval2)).Within(0.05));
            Assert.That(calc.SquareRoot(_testval3), Is.EqualTo(Math.Sqrt(_testval3)).Within(0.05));
        }
    }
}
