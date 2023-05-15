using System;
using CatSim.Core.Actions.Factory;
using Action = CatSim.Configs.Actions.Action;

namespace CatSim.Core.Controllers
{
    public class UserController
    {
        private ActionsFactory _actionsFactory;

        public Action<Action> UserActionPerformed;

        public UserController(ActionsFactory actionsFactory)
        {
            _actionsFactory = actionsFactory;
        }

        public void DoAction(Action actionType)
        {
            var action = _actionsFactory.ProduceAction(actionType);
            action.DoAction();
            UserActionPerformed?.Invoke(actionType);
        }
    }
}