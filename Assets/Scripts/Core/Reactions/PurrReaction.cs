using UnityEngine;

namespace CatSim.Core.Reactions
{
    public class PurrReaction : BaseReactionDecorator
    {
        public override void React()
        {
            Debug.Log("purr");
            base.React();
        }
    }
}