using System;
using CatSim.Configs.Actions;

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
            throw new NotImplementedException();
        }
    }
}