using UnityEngine;

namespace CatSim.Core.Reactions
{
    public class FollowTargetReaction : BaseReactionDecorator
    {
        public override void React()
        {
            Debug.Log("follow target");
            base.React();
        }
    }
}