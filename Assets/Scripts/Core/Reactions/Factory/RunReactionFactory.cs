using CatSim.Configs;
using CatSim.Configs.Reactions;

namespace CatSim.Core.Reactions.Factory
{
    public class RunReactionFactory : IReactionFactory
    {
        public IReaction ProduceReaction(ReactionConfig config, SequenceType sequenceType,
            IReaction wrappedReaction = null)
        {
            return new RunReaction(config as RunToTargetReactionConfig, sequenceType, wrappedReaction);
        }
    }
}