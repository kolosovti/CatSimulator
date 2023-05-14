using CatSim.Configs;

namespace CatSim.Core.Reactions.Factory
{
    public interface IReactionFactory
    {
        public IReaction ProduceReaction(ReactionConfig config, SequenceType sequenceType,
            IReaction wrappedReaction = null);
    }
}