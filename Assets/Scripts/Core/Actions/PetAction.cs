using CatSim.Configs.Actions;
using UnityEngine;

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
            Debug.Log("User action performed: Pet");
        }
    }
}