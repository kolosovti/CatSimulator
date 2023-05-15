using CatSim.Configs.Actions;
using CatSim.Core.Controllers;
using UnityEngine;
using UnityEngine.UI;

namespace CatSim
{
    public class UserView : MonoBehaviour
    {
        [SerializeField] private Button _playActionButton;
        [SerializeField] private Button _feedActionButton;
        [SerializeField] private Button _petActionButton;
        [SerializeField] private Button _kickActionButton;

        private UserController _userController;

        public void ConnectControllers(UserController userController)
        {
            _userController = userController;
        }

        private void Start()
        {
            _playActionButton.onClick.AddListener(OnPlayButtonClick);
            _feedActionButton.onClick.AddListener(OnFeedButtonClick);
            _petActionButton.onClick.AddListener(OnPetButtonClick);
            _kickActionButton.onClick.AddListener(OnKickButtonClick);
        }

        private void OnPlayButtonClick()
        {
            _userController.DoAction(Action.Play);
        }

        private void OnFeedButtonClick()
        {
            _userController.DoAction(Action.Feed);
        }

        private void OnPetButtonClick()
        {
            _userController.DoAction(Action.Pet);
        }

        private void OnKickButtonClick()
        {
            _userController.DoAction(Action.Kick);
        }

        private void OnDestroy()
        {
            _playActionButton.onClick.RemoveAllListeners();
            _feedActionButton.onClick.RemoveAllListeners();
            _petActionButton.onClick.RemoveAllListeners();
            _kickActionButton.onClick.RemoveAllListeners();
        }
    }
}