using CatSim.Configs.Actions;

namespace CatSim.Core.Actions.Factory
{
    public class FeedActionFactory : IActionFactory
    {
        public IAction ProduceAction(ActionConfig config)
        {
            return new FeedAction(config as FeedActionConfig);
        }
    }
}