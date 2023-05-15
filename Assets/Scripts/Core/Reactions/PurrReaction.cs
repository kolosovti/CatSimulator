using CatSim.Configs;
using CatSim.Configs.Reactions;
using UnityEngine;

namespace CatSim.Core.Reactions
{
    public class PurrReaction : BaseReactionDecorator
    {
        private PurrReactionConfig _config;

        public PurrReaction(PurrReactionConfig config, SequenceType sequenceType, IReaction wrappedReaction = null)
            : base(sequenceType, wrappedReaction)
        {
            _config = config;
        }

        public override void React()
        {
            base.React();
            Debug.Log("purr");
        }
    }
}