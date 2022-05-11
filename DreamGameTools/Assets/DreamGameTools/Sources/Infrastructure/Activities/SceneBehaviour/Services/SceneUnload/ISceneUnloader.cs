namespace DreamGameTools.Client
{
    public interface ISceneUnloader : IService
    {
        void UnloadScene(string sceneName);
    }
}