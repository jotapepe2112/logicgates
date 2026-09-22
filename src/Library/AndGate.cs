namespace Ucu.Poo.LogicGates
{
    public class AndGate : IGate
    {
        private ILogicValue input1;
        private ILogicValue input2;

        public AndGate(ILogicValue input1, ILogicValue input2)
        {
            this.input1 = input1;
            this.input2 = input2;
        }

        public bool Output { get { return this.input1.Value && this.input2.Value; } }
    }
}