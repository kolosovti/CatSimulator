using System;
using CatSim.System;
using Action = CatSim.Configs.Actions.Action;

namespace CatSim.Core.Actions.Factory
{
    public class ActionsFactory
    {
        public IAction ProduceAction(Action action)
        {
            var config = Services.Configs.Actions.GetActionConfig(action);

            switch (action)
            {
                case Action.Pet:
                    return new PetActionFactory().ProduceAction(config);
                case Action.Play:
                    return new PlayActionFactory().ProduceAction(config);
                case Action.Feed:
                    return new FeedActionFactory().ProduceAction(config);
                case Action.Kick:
                    return new KickActionFactory().ProduceAction(config);
                case Action.GoClose:
                    return new GoCloseActionFactory().ProduceAction(config);
                default:
                    throw new Exception($"Factory for action {config.Action} not defined");
            }
        }
    }
}