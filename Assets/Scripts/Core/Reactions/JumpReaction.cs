using CatSim.Configs;
using CatSim.Configs.Reactions;
using UnityEngine;

namespace CatSim.Core.Reactions
{
    public class JumpReaction : BaseReactionDecorator
    {
        private JumpReactionConfig _config;

        public JumpReaction(JumpReactionConfig config, SequenceType sequenceType, IReaction wrappedReaction = null)
            : base(sequenceType, wrappedReaction)
        {
            _config = config;
        }

        public override void React()
        {
            base.React();
            Debug.Log("jump");
        }
    }
}