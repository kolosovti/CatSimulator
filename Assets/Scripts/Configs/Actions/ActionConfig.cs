using System;
using CatSim.Configs.Reactions;
using CatSim.Core.Mood;
using UnityEngine;

namespace CatSim.Configs.Actions
{
    public enum Action
    {
        Default = 0,
        Play = 1,
        Feed = 2,
        Pet = 3,
        Kick = 4,
        GoClose = 5
    }

    public class ActionConfig : ScriptableObject
    {
        public Action Action;

        public MoodDependentReaction BadMoodReaction;
        public MoodDependentReaction GoodMoodReaction;
        public MoodDependentReaction ExcellentMoodReaction;

        public MoodDependentReaction GetReactionsByMood(MoodState state)
        {
            switch (state)
            {
                case MoodState.Bad:
                    return BadMoodReaction;
                case MoodState.Good:
                    return GoodMoodReaction;
                case MoodState.Excellent:
                    return ExcellentMoodReaction;
                default:
                    throw new Exception($"Reactions for mood state '{state}' not defined!");
            }
        }
    }
}