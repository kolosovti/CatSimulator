using CatSim.Configs.Actions;
using CatSim.Tools;

namespace CatSim.Core.Mood.Factory
{
    public abstract class BaseMoodFactory : IStateFactory
    {
        public virtual MoodState ProducePetActionMood()
        {
            return GetMoodTransitionByActionConfig(Services.Configs.Actions.GetActionConfig(Action.Pet));
        }


        protected abstract MoodState GetMoodTransitionByActionConfig(ActionConfig config);
    }
}