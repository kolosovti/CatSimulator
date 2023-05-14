using UnityEngine;

namespace CatSim.Core.Reactions
{
    public class ScratchReaction : BaseReactionDecorator
    {
        public override void React()
        {
            Debug.Log("scratch");
            base.React();
        }
    }
}