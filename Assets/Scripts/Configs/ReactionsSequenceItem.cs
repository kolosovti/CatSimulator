using System;

namespace CatSim.Configs
{
    public enum SequenceType
    {
        Append = 0,
        Join = 1
    }

    [Serializable]
    public class ReactionsSequenceItem
    {
        public ReactionConfig Reaction;
        public SequenceType SequenceType;
    }
}