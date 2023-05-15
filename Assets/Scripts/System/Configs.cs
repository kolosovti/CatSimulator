using CatSim.Configs;
using UnityEngine;

namespace CatSim.System
{
    public class Configs : Singleton<Configs>
    {
        [SerializeField] private ActionsConfig _actions;

        public ActionsConfig Actions => Instance._actions;
    }
}