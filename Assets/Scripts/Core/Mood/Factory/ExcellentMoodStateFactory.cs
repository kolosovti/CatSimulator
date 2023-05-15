using CatSim.Configs.Actions;

namespace CatSim.Core.Mood.Factory
{
    public class ExcellentMoodStateFactory : BaseMoodFactory
    {
        protected override MoodState GetMoodTransitionByActionConfig(ActionConfig config)
        {
            return config?.ExcellentMoodReaction?.MoodTransition ?? MoodState.Default;
        }
    }
}