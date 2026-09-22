using NUnit.Framework;

namespace Ucu.Poo.LogicGates
{
    public class TrueValueTest
    {
    //Test True
        [Test]
        public void Value_WhenIsTrueValue()
        {
            // Arrange
            ILogicValue trueValue = new TrueValue();

            // Act
            bool result = trueValue.Value;

            // Assert
            Assert.That(result, Is.EqualTo(true));
        }
    }
}