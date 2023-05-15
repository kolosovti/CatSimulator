using System;
using CatSim.Configs.Actions;
using UnityEngine;

namespace CatSim.Core.Actions
{
    public class KickAction : IAction
    {
        private KickActionConfig _config;

        public KickAction(KickActionConfig config)
        {
            _config = config;
        }

        public void DoAction()
        {
            Debug.Log("User action performed: Kick");
        }
    }
}