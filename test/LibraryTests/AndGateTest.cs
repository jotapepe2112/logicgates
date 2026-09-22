using NUnit.Framework;

namespace Ucu.Poo.LogicGates
{
    public class AndGateTest
    {
        [Test]
        public void Output_WhenInputAreTrue_ExpectedResultTrue()
        {
            
                //Arrange
                ILogicValue input2 = new TrueValue();
                ILogicValue input1 = new TrueValue();
                IGate andGate = new AndGate(input1, input2);
                //Act
                bool result = andGate.Output;
                //Assert
                Assert.That(result, Is.EqualTo(true));

            
        }


    ///
        [Test]
        public void Output_WhenInputAreTrueAndFalse_ExpectedResultFalse()
        {
                //Arrange
                ILogicValue input2 = new TrueValue();
                ILogicValue input1 = new FalseValue();
                IGate andGate = new AndGate(input1, input2);
                //Act
                bool result = andGate.Output;
                //Assert
                Assert.That(result, Is.EqualTo(false));

        }

        [Test]
        public void Output_WhenInputAreFalseAndTrue_ExpectedResultFalse()
        {
                //Arrange
                ILogicValue input2 = new FalseValue();
                ILogicValue input1 = new TrueValue();
                IGate andGate = new AndGate(input1, input2);
                //Act
                bool result = andGate.Output;
                //Assert
                Assert.That(result, Is.EqualTo(false));

        }

        [Test]
        public void Output_WhenInputAreFalse_ExpectedResultFalse()
        {
                //Arrange
                ILogicValue input2 = new FalseValue();
                ILogicValue input1 = new FalseValue();
                IGate andGate = new AndGate(input1, input2);
                //Act
                bool result = andGate.Output;
                //Assert
                Assert.That(result, Is.EqualTo(false));

        }


    }
}