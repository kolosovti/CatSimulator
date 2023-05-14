using CatSim.Configs;
using UnityEngine;

namespace CatSim.Tools
{
    public static class Services
    {
        public class Configs : Singleton<Configs>
        {
            [SerializeField] private ActionsConfig _actions;

            public static ActionsConfig Actions => Instance._actions;
        }
    }
}