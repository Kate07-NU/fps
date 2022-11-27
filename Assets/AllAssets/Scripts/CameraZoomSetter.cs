using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomSetter : MonoBehaviour
{
    [SerializeField] Camera subCamera = default;
    [SerializeField] Camera mainCamera = default;
    [SerializeField] GameObject backPanel = default;

    public static CameraZoomSetter instance;
    private void Awake()
    {
        if (instance == null) {
            instance = this;
        }
    }

    private void Start()
    {
        subCamera.gameObject.SetActive(false);
        backPanel.SetActive(false);
    }

    // クリックしたら，サブカメラに切り替える
    public void OnClick()
    {
        if (subCamera.gameObject.activeSelf == false) {
            subCamera.gameObject.SetActive(true);
            mainCamera.gameObject.SetActive(false);
            backPanel.SetActive(true);
        }
    }
}
