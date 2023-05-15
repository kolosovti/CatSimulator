using System;
using CatSim.Configs.Actions;
using UnityEngine;

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
            Debug.Log("User action performed: Go Close");
        }
    }
}