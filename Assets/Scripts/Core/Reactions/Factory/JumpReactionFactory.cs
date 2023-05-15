using CatSim.Configs;
using CatSim.Configs.Reactions;

namespace CatSim.Core.Reactions.Factory
{
    public class JumpReactionFactory : IReactionFactory
    {
        public IReaction ProduceReaction(ReactionConfig config, SequenceType sequenceType,
            IReaction wrappedReaction = null)
        {
            return new JumpReaction(config as JumpReactionConfig, sequenceType);
        }
    }
}