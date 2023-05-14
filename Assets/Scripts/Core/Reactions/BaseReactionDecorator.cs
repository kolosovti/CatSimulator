using System;
using CatSim.Configs;

namespace CatSim.Core.Reactions
{
    public class BaseReactionDecorator : IReaction, IDisposable
    {
        protected Action ReactionComplete;
        protected IReaction WrappedReaction;
        protected SequenceType SequenceType;

        public BaseReactionDecorator(SequenceType sequenceType, IReaction wrappedReaction = null)
        {
            WrappedReaction = wrappedReaction;
        }

        public virtual void React()
        {
            if (SequenceType == SequenceType.Append)
            {
                ReactionComplete += RunWrappedReaction;
            }
            else
            {
                RunWrappedReaction();
            }
        }

        protected virtual void RunWrappedReaction()
        {
            WrappedReaction?.React();
        }

        public void Dispose()
        {
            ReactionComplete -= RunWrappedReaction;
        }
    }
}