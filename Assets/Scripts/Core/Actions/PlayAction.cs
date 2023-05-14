using System;
using CatSim.Configs.Actions;

namespace CatSim.Core.Actions
{
    public class PlayAction : IAction
    {
        private PlayActionConfig _config;

        public PlayAction(PlayActionConfig config)
        {
            _config = config;
        }

        public void DoAction()
        {
            throw new NotImplementedException();
        }
    }
}