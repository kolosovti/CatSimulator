using CatSim.Configs;
using CatSim.Configs.Reactions;

namespace CatSim.Core.Reactions.Factory
{
    public class FollowTargetReactionFactory : IReactionFactory
    {
        public IReaction ProduceReaction(ReactionConfig config, SequenceType sequenceType,
            IReaction wrappedReaction = null)
        {
            return new FollowTargetReaction(config as FollowTargetReactionConfig, sequenceType);
        }
    }
}