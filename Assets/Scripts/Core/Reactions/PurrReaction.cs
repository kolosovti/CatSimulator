using CatSim.Configs;
using CatSim.Configs.Reactions;

namespace CatSim.Core.Reactions
{
    public class PurrReaction : BaseReactionDecorator
    {
        private PurrReactionConfig _config;

        public PurrReaction(PurrReactionConfig config, SequenceType sequenceType, IReaction wrappedReaction = null)
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