using CatSim.Configs;
using CatSim.Configs.Reactions;

namespace CatSim.Core.Reactions
{
    public class EatReaction : BaseReactionDecorator
    {
        private EatReactionConfig _config;

        public EatReaction(EatReactionConfig config, SequenceType sequenceType, IReaction wrappedReaction = null) :
            base(config, sequenceType, wrappedReaction)
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