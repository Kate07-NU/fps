using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderCamera : MonoBehaviour
{
    [SerializeField] Camera mainCamera = default;
    [SerializeField] Camera subSofaCamera = default;

    Canvas canvas;
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.worldCamera = mainCamera;
    }

    void Update()
    {
        if (mainCamera.gameObject.activeSelf == false) {
            canvas.worldCamera = subSofaCamera;
        } else {
            canvas.worldCamera = mainCamera;
        }
    }
}
