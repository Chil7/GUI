using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
   
    void Start()
    {
        
    }

    public void SwitchScene(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
    }

    public void StartNewGame()
    {
        SwitchScene("DummyGameScene");
        Debug.Log("New game has started");
    }

    public void StartLoadGame()
    {
        SwitchScene("DummyGameScene");
        Debug.Log("Load game has started");
    }
}
