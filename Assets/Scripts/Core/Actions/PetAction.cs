using System;
using CatSim.Configs.Actions;

namespace CatSim.Core.Actions
{
    public class PetAction : IAction
    {
        private PetActionConfig _config;

        public PetAction(PetActionConfig config)
        {
            _config = config;
        }

        public void DoAction()
        {
            throw new NotImplementedException();
        }
    }
}