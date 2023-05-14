using UnityEngine;

namespace CatSim.Core.Reactions
{
    public class EatReaction : BaseReactionDecorator
    {
        public override void React()
        {
            Debug.Log("eat");
            base.React();
        }
    }
}