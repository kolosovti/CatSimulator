using UnityEngine;

namespace CatSim.Configs.Reactions
{
    [CreateAssetMenu(fileName = "FollowTargetReaction", menuName = "Create/Configs/Reactions/FollowTargetReaction")]
    public class FollowTargetReactionConfig : ReactionConfig
    {
        public float RunSpeed;
    }
}