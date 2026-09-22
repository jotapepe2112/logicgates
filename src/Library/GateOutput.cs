using System.Linq;

namespace Ucu.Poo.LogicGates
{
    public class GateOutput : ILogicValue
    {
        private IGate gate;
        public GateOutput (IGate Gate)
        {
            this.gate = gate;
        }

        public bool Value { get { return gate.Output; }}
    }

}