using CatSim.Configs.Actions;

namespace CatSim.Core.Actions.Factory
{
    public class PlayActionFactory : IActionFactory
    {
        public IAction ProduceAction(ActionConfig config)
        {
            return new PlayAction(config as PlayActionConfig);
        }
    }
}