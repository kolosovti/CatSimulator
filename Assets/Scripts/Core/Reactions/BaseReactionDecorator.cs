using System;
using CatSim.Configs;
using UnityEngine;

namespace CatSim.Core.Reactions
{
    public class BaseReactionDecorator : IReaction, IDisposable
    {
        private ReactionConfig _baseReactionConfig;

        protected Action ReactionComplete;
        protected IReaction WrappedReaction;
        protected SequenceType SequenceType;

        public BaseReactionDecorator(ReactionConfig baseReactionConfig, SequenceType sequenceType,
            IReaction wrappedReaction = null)
        {
            _baseReactionConfig = baseReactionConfig;
            WrappedReaction = wrappedReaction;
            SequenceType = sequenceType;
            if (SequenceType == SequenceType.Append)
            {
                ReactionComplete += RunWrappedReaction;
            }
        }

        public virtual void React()
        {
            Debug.Log($"Reaction: {_baseReactionConfig.Reaction}, sequence type: {SequenceType}");
            if (SequenceType == SequenceType.Join)
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