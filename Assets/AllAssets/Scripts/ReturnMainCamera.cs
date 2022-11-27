using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnMainCamera : MonoBehaviour
{
    [SerializeField] Camera subTVCamera = default;
    [SerializeField] Camera subChestCamera = default;
    [SerializeField] Camera mainCamera = default;
    [SerializeField] GameObject backPanel = default;

    // ボタンがクリックされたら，メインカメラに切り替える
    public void OnClickButton()
    {
        if (subTVCamera.gameObject.activeSelf == true) {
            subTVCamera.gameObject.SetActive(false);
            mainCamera.gameObject.SetActive(true);
            backPanel.SetActive(false);
        } else if (subChestCamera.gameObject.activeSelf == true) {
            subChestCamera.gameObject.SetActive(false);
            mainCamera.gameObject.SetActive(true);
            backPanel.SetActive(false);
        }
    }
}
