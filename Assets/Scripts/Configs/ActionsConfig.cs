using CatSim.Configs.Actions;
using UnityEngine;

namespace CatSim.Configs
{
    [CreateAssetMenu(fileName = "ActionsConfig", menuName = "Create/Configs/ActionsConfig")]
    public class ActionsConfig : ScriptableObject
    {
        [SerializeField] private ActionConfig[] _actions;

        public ActionConfig[] Actions => _actions;

        public ActionConfig GetActionConfig(Action action)
        {
            foreach (var actionConfig in Actions)
            {
                if (actionConfig.Action == action)
                {
                    return actionConfig;
                }
            }

            return null;
        }
    }
}