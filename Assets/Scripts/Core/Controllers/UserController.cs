using CatSim.Configs.Actions;
using CatSim.Core.Actions.Factory;
using CatSim.System;

namespace CatSim.Core.Controllers
{
    public class UserController
    {
        private ActionsFactory _actionsFactory;

        public global::System.Action<Action> UserActionPerformed;

        public UserController(ActionsFactory actionsFactory)
        {
            _actionsFactory = actionsFactory;
        }

        public void DoAction(Action actionType)
        {
            var actionConfig = Services.Configs.Actions.GetActionConfig(actionType);
            var action = _actionsFactory.ProduceAction(actionConfig);
            action.DoAction();
            UserActionPerformed?.Invoke(actionType);
        }
    }
}