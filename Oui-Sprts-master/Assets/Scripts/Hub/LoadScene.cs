using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public Scene sceneToLoad;

    public void LoadGameMode()
    {
        SceneManager.LoadScene(sceneToLoad.ToString());
    }
}
