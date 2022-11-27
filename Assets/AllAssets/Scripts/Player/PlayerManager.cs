using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    Rigidbody rb;
    float x;
    float z;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        z = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        Vector3 direction = transform.position + new Vector3(x, 0, z);
        transform.LookAt(direction);
        rb.velocity = new Vector3(x, 0, z) * 3f; // 速度設定
    }
}
