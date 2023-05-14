using UnityEngine;

namespace CatSim.Configs.Reactions
{
    [CreateAssetMenu(fileName = "EatReaction", menuName = "Create/Configs/Reactions/EatReaction")]
    public class EatReactionConfig : ReactionConfig
    {
        public float Duration;
    }
}