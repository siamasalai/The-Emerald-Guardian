using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Public method to load a scene by its name
    public void LoadScene(string sceneName)
    {
        // SceneManager.LoadScene is the function that handles the transition
        SceneManager.LoadScene(sceneName);
    }
}