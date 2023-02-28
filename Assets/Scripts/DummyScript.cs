using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DummyScript : MonoBehaviour
{
    public void SwitchScene(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
    }
}
