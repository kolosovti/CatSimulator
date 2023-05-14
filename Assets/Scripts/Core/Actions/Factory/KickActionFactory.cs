using CatSim.Configs.Actions;

namespace CatSim.Core.Actions.Factory
{
    public class KickActionFactory : IActionFactory
    {
        public IAction ProduceAction(ActionConfig config)
        {
            return new KickAction(config as KickActionConfig);
        }
    }
}