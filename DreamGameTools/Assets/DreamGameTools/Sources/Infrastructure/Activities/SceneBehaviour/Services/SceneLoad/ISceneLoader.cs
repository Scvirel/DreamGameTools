using UnityEngine.SceneManagement;

namespace DreamGameTools.Client
{
    public interface ISceneLoader : IService
    {
        void LoadScene(string sceneName, LoadSceneMode loadSceneMode);
    }
}