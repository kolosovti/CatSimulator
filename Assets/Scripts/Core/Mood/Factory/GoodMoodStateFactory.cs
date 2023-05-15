using CatSim.Configs.Actions;

namespace CatSim.Core.Mood.Factory
{
    public class GoodMoodStateFactory : BaseMoodFactory
    {
        protected override MoodState GetMoodTransitionByActionConfig(ActionConfig config)
        {
            return config?.GoodMoodReaction?.MoodTransition ?? MoodState.Default;
        }
    }
}