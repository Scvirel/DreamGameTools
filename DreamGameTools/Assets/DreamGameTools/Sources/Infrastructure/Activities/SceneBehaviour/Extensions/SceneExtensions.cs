using UnityEngine;
using UnityEngine.SceneManagement;

namespace DreamGameTools.Client
{
    public static class SceneExtensions
    {
        public static void SetActive(this Scene scene)
        {
            SceneManager.SetActiveScene(scene);
        }
        public static bool IsActive(this Scene scene)
        {
            return SceneManager.GetActiveScene().Equals(scene);
        }
        public static void UnloadScene(this Scene scene)
        {
            SceneManager.UnloadSceneAsync(scene);
        }
        public static void Merge(this Scene sourceScene, Scene destinationScene)
        {
            if (destinationScene.IsValid())
            {
                SceneManager.MergeScenes(sourceScene, destinationScene);
            }
        }
        public static void MoveGameObjectToScene(this Scene scene, GameObject obj)
        {
            SceneManager.MoveGameObjectToScene(obj, scene);
        }

    }
}