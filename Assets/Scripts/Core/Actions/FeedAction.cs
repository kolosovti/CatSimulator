using CatSim.Configs.Actions;
using UnityEngine;

namespace CatSim.Core.Actions
{
    public class FeedAction : IAction
    {
        private FeedActionConfig _config;

        public FeedAction(FeedActionConfig config)
        {
            _config = config;
        }

        public void DoAction()
        {
            Debug.Log("User action performed: Feed");
        }
    }
}