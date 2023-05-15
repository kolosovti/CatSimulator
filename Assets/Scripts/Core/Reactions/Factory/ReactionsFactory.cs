using System;
using CatSim.Configs;
using CatSim.Core.Reactions;
using CatSim.Core.Reactions.Factory;

namespace CatSim
{
    public class ReactionsFactory : IReactionFactory
    {
        public IReaction ProduceReaction(ReactionConfig config, SequenceType sequenceType,
            IReaction wrappedReaction = null)
        {
            IReactionFactory factory;
            switch (config.Reaction)
            {
                case Reaction.Bite:
                    factory = new BiteReactionFactory();
                    break;
                case Reaction.Eat:
                    factory = new EatReactionFactory();
                    break;
                case Reaction.FollowTarget:
                    factory = new FollowTargetReactionFactory();
                    break;
                case Reaction.Jump:
                    factory = new JumpReactionFactory();
                    break;
                case Reaction.MessUp:
                    factory = new MessUpReactionFactory();
                    break;
                case Reaction.Purr:
                    factory = new PurrReactionFactory();
                    break;
                case Reaction.RunToTarget:
                    factory = new RunReactionFactory();
                    break;
                case Reaction.Scratch:
                    factory = new ScratchReactionFactory();
                    break;
                case Reaction.Sit:
                    factory = new SitReactionFactory();
                    break;
                case Reaction.WagTail:
                    factory = new WagTailReactionFactory();
                    break;
                default:
                    throw new Exception($"Factory for reaction {config.Reaction} not defined");
            }

            return factory.ProduceReaction(config, sequenceType, wrappedReaction);
        }
    }
}