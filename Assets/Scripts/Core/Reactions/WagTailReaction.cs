using CatSim.Configs;
using CatSim.Configs.Reactions;
using UnityEngine;

namespace CatSim.Core.Reactions
{
    public class WagTailReaction : BaseReactionDecorator
    {
        private WagTailReactionConfig _config;

        public override void React()
        {
            Debug.Log("wag tail");
            base.React();
        }

        public WagTailReaction(WagTailReactionConfig config, SequenceType sequenceType,
            IReaction wrappedReaction = null) : base(sequenceType, wrappedReaction)
        {
            _config = config;
        }
    }
}