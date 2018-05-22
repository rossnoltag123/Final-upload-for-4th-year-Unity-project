using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {
  
    public void SceneToLoad(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
