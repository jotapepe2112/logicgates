using NUnit.Framework;

namespace Ucu.Poo.LogicGates
{
    public class NotGateTest
    {
        [Test]
        public void Output_WhenInputIsTrue_ExpectedResultFalse()
        {
            //Arrange
            ILogicValue input = new TrueValue();
            IGate notGate = new NotGate(input);

            //Act
            bool result = notGate.Output;

            //Assert
            Assert.That(result, Is.EqualTo(false));

        }

        [Test]
        public void Output_WhenInputIsFalse_ExpectedResultTrue()
        {
            //Arrange
            ILogicValue input = new FalseValue();
            IGate notGate = new NotGate(input);

            //Act
            bool result = notGate.Output;

            //Assert
            Assert.That(result, Is.EqualTo(true));

        }
    }
}