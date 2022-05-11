using UnityEngine.SceneManagement;

namespace DreamGameTools.Client
{
    public sealed class SyncSceneLoader : ISyncSceneLoader
    {
        public void LoadScene(string sceneName, LoadSceneMode loadSceneMode)
        {
            SceneManager.LoadScene(sceneName, loadSceneMode);
        }
    }
}