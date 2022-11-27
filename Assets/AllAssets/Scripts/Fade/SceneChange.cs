using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // シーン変更
    [SerializeField] string nextSceneName = default;
    [SerializeField] Canvas itemBoxCanvas = default;

    public FadeController fadeController;

    public void NextScene()
    {
        // ItemBoxCanvasを非表示にする
        if (itemBoxCanvas != null) {
            itemBoxCanvas.gameObject.SetActive(false);
        }
        fadeController.LoadScene(nextSceneName);
    }
}