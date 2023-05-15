using CatSim.Configs;
using CatSim.Configs.Reactions;

namespace CatSim.Core.Reactions.Factory
{
    public class WagTailReactionFactory : IReactionFactory
    {
        public IReaction ProduceReaction(ReactionConfig config, SequenceType sequenceType,
            IReaction wrappedReaction = null)
        {
            return new WagTailReaction(config as WagTailReactionConfig, sequenceType, wrappedReaction);
        }
    }
}