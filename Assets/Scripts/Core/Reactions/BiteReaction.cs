using CatSim.Configs;
using CatSim.Configs.Reactions;

namespace CatSim.Core.Reactions
{
    public class BiteReaction : BaseReactionDecorator
    {
        private BiteReactionConfig _config;

        public BiteReaction(BiteReactionConfig config, SequenceType sequenceType, IReaction wrappedReaction = null)
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