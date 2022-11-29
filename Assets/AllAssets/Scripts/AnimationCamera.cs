using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCamera : MonoBehaviour
{
    [SerializeField] Camera subOpenCamera = default;
    [SerializeField] Camera mainCamera = default;

    public void ReturnMainCamera()
    {
        subOpenCamera.gameObject.SetActive(false);
        mainCamera.gameObject.SetActive(true);
    }
}
