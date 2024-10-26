using LogicAPI.Server.Components;

namespace MoreGates.Server {
    public class XNOrGate : LogicComponent {
        protected override void DoLogicUpdate() {
            base.Outputs[0].On = base.Inputs[0].On == base.Inputs[1].On;
        }

        public override void Dispose() {
            base.Dispose();
        }
    }
}