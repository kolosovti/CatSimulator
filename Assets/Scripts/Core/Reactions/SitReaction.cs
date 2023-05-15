using CatSim.Configs;
using CatSim.Configs.Reactions;

namespace CatSim.Core.Reactions
{
    public class SitReaction : BaseReactionDecorator
    {
        private SitReactionConfig _config;

        public SitReaction(SitReactionConfig config, SequenceType sequenceType, IReaction wrappedReaction = null)
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