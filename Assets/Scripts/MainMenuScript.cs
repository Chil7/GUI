using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;

public class MainMenuScript : MonoBehaviour
{
    private Animator anim;
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void SwitchSceneAnim(string _sceneName)
    {
        
        anim.SetTrigger("SwitchScene");
        StartCoroutine(SceneChange(_sceneName));
    }

    public void SwitchScene(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
        Debug.Log(_sceneName);
    }

    public void QuitToDesktop()
    {
        Application.Quit();
        Debug.Log("Player has exited to desktop");
    }

    IEnumerator SceneChange(string _sceneName)
    {
        float animLength = anim.GetCurrentAnimatorStateInfo(0).length;
        while (animLength > 0)
        {
            yield return new WaitForSeconds(animLength);
            SwitchScene(_sceneName);
        }

    }
}
