using UnityEngine;

namespace CatSim.Core.Reactions
{
    public class SitReaction : BaseReactionDecorator
    {
        public override void React()
        {
            Debug.Log("sit");
            base.React();
        }
    }
}