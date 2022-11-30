using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderCamera : MonoBehaviour
{
    [SerializeField] Camera mainCamera = default;
    [SerializeField] Camera subSofaCamera = default;
    [SerializeField] Camera subChestCamera = default;

    Canvas canvas;
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.worldCamera = mainCamera;
    }

    void Update()
    {
        if (mainCamera.gameObject.activeSelf == false && subSofaCamera.gameObject.activeSelf == true) {
            canvas.worldCamera = subSofaCamera;
        } else if (mainCamera.gameObject.activeSelf == false && subChestCamera.gameObject.activeSelf == true) {
            canvas.worldCamera = subChestCamera;
        } else {
            canvas.worldCamera =mainCamera;
        }
    }
}
