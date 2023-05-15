using CatSim.Configs;
using CatSim.Configs.Reactions;

namespace CatSim.Core.Reactions
{
    public class RunReaction : BaseReactionDecorator
    {
        private RunToTargetReactionConfig _config;

        public RunReaction(RunToTargetReactionConfig config, SequenceType sequenceType,
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