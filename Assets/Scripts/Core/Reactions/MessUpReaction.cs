using CatSim.Configs;
using CatSim.Configs.Reactions;
using UnityEngine;

namespace CatSim.Core.Reactions
{
    public class MessUpReaction : BaseReactionDecorator
    {
        private MessUpReactionConfig _config;

        public MessUpReaction(MessUpReactionConfig config, SequenceType sequenceType, IReaction wrappedReaction = null)
            : base(sequenceType, wrappedReaction)
        {
            _config = config;
        }

        public override void React()
        {
            base.React();
            Debug.Log("mess up");
            ReactionComplete?.Invoke();
        }
    }
}