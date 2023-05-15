using System.Collections.Generic;
using System.Linq;
using CatSim.Configs.Actions;
using CatSim.Core.Reactions;
using CatSim.Core.Reactions.Factory;
using CatSim.System;

namespace CatSim.Core.Controllers
{
    public class CatController
    {
        private UserController _userController;
        private ICatModel _catModel;
        private IReactionFactory _reactionsFactory;

        public CatController(UserController userController, ICatModel catModel, IReactionFactory reactionsFactory,
            IFac)
        {
            _catModel = catModel;
            _userController = userController;
            _reactionsFactory = reactionsFactory;
            _userController.UserActionPerformed += OnUserActionPerformed;
        }

        private void OnUserActionPerformed(Action action)
        {
            var actionConfig = Services.Configs.Actions.GetActionConfig(action);
            var reactionsConfig = actionConfig.GetReactionsByMood(_catModel.Mood);
            var reactions = new List<IReaction>();

            foreach (var reactionsSequenceItem in reactionsConfig.ReactionsSequence)
            {
                reactions.Add(_reactionsFactory.ProduceReaction(
                    reactionsSequenceItem.Reaction,
                    reactionsSequenceItem.SequenceType,
                    reactions.LastOrDefault()));
            }



            if (reactions.Count > 0)
            {
                reactions[0].React();
            }
        }
    }
}