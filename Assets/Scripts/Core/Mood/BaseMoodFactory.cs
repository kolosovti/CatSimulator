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

        public MoodState ProduceFeedActionMood()
        {
            return GetMoodTransitionByActionConfig(Services.Configs.Actions.GetActionConfig(Action.Feed));
        }

        public MoodState ProducePlayActionMood()
        {
            return GetMoodTransitionByActionConfig(Services.Configs.Actions.GetActionConfig(Action.Play));
        }

        public MoodState ProduceKickActionMood()
        {
            return GetMoodTransitionByActionConfig(Services.Configs.Actions.GetActionConfig(Action.Kick));
        }

        public MoodState ProduceGoCloseActionMood()
        {
            return GetMoodTransitionByActionConfig(Services.Configs.Actions.GetActionConfig(Action.GoClose));
        }

        protected abstract MoodState GetMoodTransitionByActionConfig(ActionConfig config);
    }
}