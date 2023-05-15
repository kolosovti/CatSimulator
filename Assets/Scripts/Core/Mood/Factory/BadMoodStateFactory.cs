using CatSim.Configs.Actions;

namespace CatSim.Core.Mood.Factory
{
    public class BadMoodStateFactory : BaseMoodFactory
    {
        protected override MoodState GetMoodTransitionByActionConfig(ActionConfig config)
        {
            return config?.BadMoodReaction?.MoodTransition ?? MoodState.Default;
        }
    }
}