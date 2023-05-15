using CatSim.Configs.Actions;
using CatSim.System;

namespace CatSim.Core.Mood.Factory
{
    public abstract class BaseMoodFactory : IMoodStateFactory
    {
        public virtual MoodState ProduceMoodState(ActionConfig config)
        {
            return GetMoodTransitionByActionConfig(config);
        }

        protected abstract MoodState GetMoodTransitionByActionConfig(ActionConfig config);
    }
}