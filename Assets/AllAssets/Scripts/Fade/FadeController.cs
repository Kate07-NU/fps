using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeController : MonoBehaviour
{
    private string _SceneName;

    public void LoadScene(string sceneName)
    {
        GetComponent<Animator>().enabled = true; // アニメーション実行
        _SceneName = sceneName;
    }

    public void LoadSceneEvent()
    {
        SceneManager.LoadScene(_SceneName);
    }

}
