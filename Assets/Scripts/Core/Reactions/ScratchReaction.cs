using CatSim.Configs;
using CatSim.Configs.Reactions;

namespace CatSim.Core.Reactions
{
    public class ScratchReaction : BaseReactionDecorator
    {
        private ScratchReactionConfig _config;

        public ScratchReaction(ScratchReactionConfig config, SequenceType sequenceType,
            IReaction wrappedReaction = null) : base(config, sequenceType, wrappedReaction)
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