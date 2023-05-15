using CatSim.Configs;
using CatSim.Configs.Reactions;
using UnityEngine;

namespace CatSim.Core.Reactions
{
    public class WagTailReaction : BaseReactionDecorator
    {
        private WagTailReactionConfig _config;

        public WagTailReaction(WagTailReactionConfig config, SequenceType sequenceType,
            IReaction wrappedReaction = null) : base(sequenceType, wrappedReaction)
        {
            _config = config;
        }

        public override void React()
        {
            base.React();
            Debug.Log("wag tail");
        }
    }
}