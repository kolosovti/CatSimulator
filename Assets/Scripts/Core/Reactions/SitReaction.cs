using CatSim.Configs;
using CatSim.Configs.Reactions;
using UnityEngine;

namespace CatSim.Core.Reactions
{
    public class SitReaction : BaseReactionDecorator
    {
        private SitReactionConfig _config;

        public SitReaction(SitReactionConfig config, SequenceType sequenceType, IReaction wrappedReaction = null)
            : base(sequenceType, wrappedReaction)
        {
            _config = config;
        }

        public override void React()
        {
            base.React();
            Debug.Log("sit");
            ReactionComplete?.Invoke();
        }
    }
}