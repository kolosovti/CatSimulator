using System;
using CatSim.Configs.Actions;
using UnityEngine;

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
            Debug.Log("User action performed: Play");
        }
    }
}