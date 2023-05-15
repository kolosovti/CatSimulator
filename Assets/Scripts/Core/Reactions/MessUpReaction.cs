using CatSim.Configs;
using CatSim.Configs.Reactions;

namespace CatSim.Core.Reactions
{
    public class MessUpReaction : BaseReactionDecorator
    {
        private MessUpReactionConfig _config;

        public MessUpReaction(MessUpReactionConfig config, SequenceType sequenceType, IReaction wrappedReaction = null)
            : base(config, sequenceType, wrappedReaction)
        {
            _config = config;
        }

        public override void React()
        {
            base.React();
            ReactionComplete?.Invoke();
        }
    }
}