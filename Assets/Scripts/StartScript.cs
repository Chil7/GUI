using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    private Animator anim;

    [SerializeField] private RectTransform LoadFiles;
    [SerializeField] private RectTransform DeleteLoadFiles;

    [SerializeField] private ScrollRect scrollRect;
    

    void Start()
    {
        anim = GetComponent<Animator>();
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

    public void Startup()
    {
        anim.SetTrigger("Start");
    }

    public void LoadMenu()
    {
        anim.SetTrigger("LoadMenu");
    }

    //Scrollview purposes
    public void ScrollViewChange(string _gameObject)
    {
        if (_gameObject == "Load")
        {
            scrollRect.content = LoadFiles;
        }

        else if (_gameObject == "Delete")
        {
            scrollRect.content = DeleteLoadFiles;
        }
        
    }
}
