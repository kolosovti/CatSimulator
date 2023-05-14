using CatSim.Configs.Actions;

namespace CatSim.Core.Actions.Factory
{
    public interface IActionFactory
    {
        IAction ProduceAction(ActionConfig config);
    }
}