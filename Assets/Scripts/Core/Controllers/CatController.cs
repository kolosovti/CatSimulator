using System.Collections;
using System.Collections.Generic;
using CatSim.Configs.Actions;
using UnityEngine;

namespace CatSim.Core.Controllers
{
    public class CatController
    {
        private UserController _userController;
        private ICatModel _catModel;

        public CatController(UserController userController, ICatModel catModel)
        {
            _catModel = catModel;
            _userController = userController;
            _userController.UserActionPerformed += OnUserActionPerformed;
        }

        private void OnUserActionPerformed(Action action)
        {

        }
    }
}
