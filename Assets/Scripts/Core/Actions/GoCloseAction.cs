using System;
using CatSim.Configs.Actions;

namespace CatSim.Core.Actions
{
    public class GoCloseAction : IAction
    {
        private GoCloseActionConfig _config;

        public GoCloseAction(GoCloseActionConfig config)
        {
            _config = config;
        }

        public void DoAction()
        {
            throw new NotImplementedException();
        }
    }
}