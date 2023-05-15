using CatSim.Core.Actions.Factory;
using CatSim.Core.Controllers;
using UnityEngine;

namespace CatSim
{
    public class EntryPoint : MonoBehaviour
    {
        private CatModel _catModel;

        private CatService _catService;

        private CatController _catController;
        private UserController _userController;

        private void Start()
        {
            CreateModels();
            CreateServices();
            CreateControllers();
        }

        private void CreateModels()
        {
            _catModel = new CatModel();
        }

        private void CreateServices()
        {
            _catService = new CatService(_catModel);
        }

        private void CreateControllers()
        {
            _userController = new UserController(new ActionsFactory());

            //TODO: extract to ContextManager, resolve controllers and services by GetController<T>, GetService<T>
            _catController = new CatController(_catModel, 
                _catService, 
                _userController, 
                new ReactionsFactory(),
                new MoodStateAbstractFactory(_catModel));
        }
    }
}