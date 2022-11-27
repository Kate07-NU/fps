using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRotation : MonoBehaviour
{
    [SerializeField] Transform zoomObjParent;
    // マウスドラッグによってアイテムを回転させる
    [SerializeField] Transform canvas;

    float speed = 100;
    private void Update()
    {
        if (Input.GetMouseButton(0)) {
            float dy = -Input.GetAxis("Mouse X") * speed;
            float dx = Input.GetAxis("Mouse Y") * speed;
            // zoomObjParent.Rotate(dx, dy, 0);
            zoomObjParent.RotateAround(transform.position, canvas.transform.rotation * Vector3.up, dy);
            zoomObjParent.RotateAround(transform.position, canvas.transform.rotation * Vector3.right, dx);
        }
    }
}