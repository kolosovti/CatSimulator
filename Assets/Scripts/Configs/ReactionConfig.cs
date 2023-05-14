using System;
using UnityEngine;

namespace CatSim.Configs
{
    public enum Reaction
    {
        Default = 0,
        Eat = 1,
        FollowTarget = 2,
        Purr = 3,
        Scratch = 4,
        Sit = 5,
        WagTail = 6,
        Jump = 7,
        Bite = 8,
        RunToTarget = 9,
        MessUp = 10
    }

    [Serializable]
    public class ReactionConfig : ScriptableObject
    {
        public Reaction Reaction = Reaction.Default;
    }
}