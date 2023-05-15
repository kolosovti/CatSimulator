using System;
using System.Collections.Generic;
using System.Linq;
using CatSim.Core.Mood.Factory;
using CatSim.Core.Reactions;
using CatSim.Core.Reactions.Factory;
using CatSim.System;
using Action = CatSim.Configs.Actions.Action;

namespace CatSim.Core.Controllers
{
    public class CatController : IDisposable
    {
        private ICatModel _catModel;
        private CatService _catService;
        private UserController _userController;
        private IReactionFactory _reactionsFactory;
        private IMoodStateFactory _moodStateFactory;

        public CatController(ICatModel catModel, CatService catService, UserController userController,
            IReactionFactory reactionsFactory, IMoodStateFactory moodStateFactory)
        {
            _catModel = catModel;
            _catService = catService;
            _userController = userController;
            _reactionsFactory = reactionsFactory;
            _moodStateFactory = moodStateFactory;
            _userController.UserActionPerformed += OnUserActionPerformed;
        }

        private void OnUserActionPerformed(Action action)
        {
            var actionConfig = Services.Configs.Actions.GetActionConfig(action);
            var reactionsConfig = actionConfig.GetReactionsByMood(_catModel.Mood);
            var reactions = new List<IReaction>();

            _catService.SetMood(_moodStateFactory.ProduceMoodState(actionConfig));

            foreach (var reactionsSequenceItem in reactionsConfig.ReactionsSequence.Reverse())
            {
                reactions.Add(_reactionsFactory.ProduceReaction(
                    reactionsSequenceItem.Reaction,
                    reactionsSequenceItem.SequenceType,
                    reactions.LastOrDefault()));
            }

            reactions.LastOrDefault()?.React();
        }

        public void Dispose()
        {
            _userController.UserActionPerformed -= OnUserActionPerformed;
        }
    }
}