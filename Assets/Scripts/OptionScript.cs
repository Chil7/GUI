using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.Animations;


public class OptionScript : MonoBehaviour
{
    private Animator anim;

    [SerializeField] private GameObject audioPanel;

    // Start is called before the first frame update
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

    IEnumerator SceneChange(string _sceneName)
    {
        float animLength = anim.GetCurrentAnimatorStateInfo(0).length;
        while (animLength > 0)
        {
            yield return new WaitForSeconds(animLength);
            SwitchScene(_sceneName);
        }

    }

    public void TogglePanel()
    {
        audioPanel.SetActive(!audioPanel.activeSelf);
    }
}
