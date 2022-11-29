using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColloder : MonoBehaviour
{
    [SerializeField] Camera subCamera = default;
    BoxCollider boxCollider;
    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
    }

    void Update()
    {
        if (subCamera.gameObject.activeSelf == true) {
            boxCollider.enabled = false;
        } else {
            boxCollider.enabled = true;
        }
    }
}
