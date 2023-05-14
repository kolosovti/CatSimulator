using CatSim.Configs.Actions;

namespace CatSim.Core.Actions.Factory
{
    public class GoCloseActionFactory : IActionFactory
    {
        public IAction ProduceAction(ActionConfig config)
        {
            return new GoCloseAction(config as GoCloseActionConfig);
        }
    }
}