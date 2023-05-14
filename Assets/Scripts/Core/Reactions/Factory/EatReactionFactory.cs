using CatSim.Configs;
using CatSim.Configs.Reactions;

namespace CatSim.Core.Reactions.Factory
{
    public class EatReactionFactory : IReactionFactory
    {
        public IReaction ProduceReaction(ReactionConfig config, SequenceType sequenceType,
            IReaction wrappedReaction = null)
        {
            return new EatReaction(config as EatReactionConfig, sequenceType);
        }
    }
}