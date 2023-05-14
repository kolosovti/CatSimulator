using System;
using CatSim.Configs.Actions;
using CatSim.Core.Mood;

namespace CatSim.Configs.Reactions
{
    [Serializable]
    public class MoodDependentReaction
    {
        public ReactionsSequenceItem[] ReactionsSequence;
        public ActionConfig[] InterruptionActions;
        public MoodState MoodTransition = MoodState.Default;
    }
}