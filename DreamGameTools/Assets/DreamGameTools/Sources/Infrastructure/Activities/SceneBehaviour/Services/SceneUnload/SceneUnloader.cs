using UnityEngine.SceneManagement;

namespace DreamGameTools.Client
{
    public sealed class SceneUnloader : ISceneUnloader
    {
        public void UnloadScene(string sceneName)
        {
            SceneManager.UnloadSceneAsync(sceneName);
        }
    }
}