using UnityEngine;

namespace CatSim.Core.Reactions
{
    public class WagTailReaction : BaseReactionDecorator
    {
        public override void React()
        {
            Debug.Log("wag tail");
            base.React();
        }
    }
}