using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    public GameObject menuCanvas;
    public GameObject creditsCanvas;
    public GameObject ControlsCanvas;

    public GameObject currentCanvas;

    public int lobbySceneint;

    private void Awake()
    {
        currentCanvas = menuCanvas;
    }

    public void OnPlay()
    {
        SceneManager.LoadScene(lobbySceneint);
    }

    public void OnExit()
    {
        if(currentCanvas == menuCanvas)
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit();
#endif
        }
    }
    public void OnControls()
    {
        currentCanvas.SetActive(false);
        currentCanvas = ControlsCanvas;
        currentCanvas.SetActive(true);
    }
    public void OnCredits()
    {
        currentCanvas.SetActive(false);
        currentCanvas = ControlsCanvas;
        currentCanvas.SetActive(true);
    }

    public void OnBack()
    {
        if(currentCanvas != menuCanvas)
        {
            currentCanvas.SetActive(false);
            currentCanvas = menuCanvas;
            currentCanvas.SetActive(true);
        }        
    }
}
