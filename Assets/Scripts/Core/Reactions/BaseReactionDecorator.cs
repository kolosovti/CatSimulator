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

        //TODO: fix inversed reactions order, possible errors when mix join and append reactions types
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