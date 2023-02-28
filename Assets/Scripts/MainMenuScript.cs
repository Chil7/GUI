using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    
    void Start()
    {
        
    }

    public void SwitchScene(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
        Debug.Log("Player went to options");
    }

    public void QuitToDesktop()
    {
        Application.Quit();
        Debug.Log("Player has exited to desktop");
    }
}
