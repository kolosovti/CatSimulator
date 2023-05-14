using UnityEngine;

namespace CatSim.Core.Reactions
{
    public class RunReaction : BaseReactionDecorator
    {
        public override void React()
        {
            Debug.Log("run");
            base.React();
        }
    }
}