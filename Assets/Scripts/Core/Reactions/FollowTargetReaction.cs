using CatSim.Configs;
using CatSim.Configs.Reactions;
using UnityEngine;

namespace CatSim.Core.Reactions
{
    public class FollowTargetReaction : BaseReactionDecorator
    {
        private FollowTargetReactionConfig _config;

        public FollowTargetReaction(FollowTargetReactionConfig config, SequenceType sequenceType,
            IReaction wrappedReaction = null)
            : base(sequenceType, wrappedReaction)
        {
            _config = config;
        }

        public override void React()
        {
            base.React();
            Debug.Log("follow target");
            ReactionComplete?.Invoke();
        }
    }
}