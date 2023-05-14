using CatSim.Configs.Actions;

namespace CatSim.Core.Actions.Factory
{
    public class PetActionFactory : IActionFactory
    {
        public IAction ProduceAction(ActionConfig config)
        {
            return new PetAction(config as PetActionConfig);
        }
    }
}