using CatSim.Configs;
using CatSim.Configs.Reactions;
using UnityEngine;

namespace CatSim.Core.Reactions
{
    public class EatReaction : BaseReactionDecorator
    {
        private EatReactionConfig _config;

        public EatReaction(EatReactionConfig config, SequenceType sequenceType, IReaction wrappedReaction = null) :
            base(sequenceType, wrappedReaction)
        {
            _config = config;
        }

        public override void React()
        {
            Debug.Log("eat");
            base.React();
        }
    }
}