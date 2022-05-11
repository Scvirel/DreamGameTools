using UnityEngine.SceneManagement;

namespace DreamGameTools.Client
{
    public sealed class AsyncSceneLoader : IAsyncSceneLoader
    {
        public void LoadScene(string sceneName, LoadSceneMode loadSceneMode)
        {
            SceneManager.LoadSceneAsync(sceneName, loadSceneMode);
        }
    }
}