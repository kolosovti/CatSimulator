using CatSim.Configs.Actions;
using CatSim.Core.Controllers;
using UnityEngine;
using UnityEngine.UI;

namespace CatSim
{
    public class UserView : MonoBehaviour
    {
        [SerializeField] private Button _petActionButton;

        private UserController _userController;

        public void ConnectControllers(UserController userController)
        {
            _userController = userController;
        }

        private void Start()
        {
            _petActionButton.onClick.AddListener(OnPetButtonClick);
        }

        private void OnPetButtonClick()
        {
            _userController.DoAction(Action.Pet);
        }

        private void OnDestroy()
        {
            _petActionButton.onClick.RemoveAllListeners();
        }
    }
}