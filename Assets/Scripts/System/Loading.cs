using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace CatSim.System
{
    public class Loading : MonoBehaviour
    {
        private const int MainSceneIndex = 1;

        [SerializeField] private Image _loadingProgressView;

        private void Start()
        {
            StartCoroutine(LoadingSceneCoroutine());
        }

        private IEnumerator LoadingSceneCoroutine()
        {
            var sceneLoadingOperation = SceneManager.LoadSceneAsync(MainSceneIndex);

            while (!sceneLoadingOperation.isDone)
            {
                _loadingProgressView.fillAmount = sceneLoadingOperation.progress;
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
