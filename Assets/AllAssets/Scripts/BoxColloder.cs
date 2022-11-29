using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColloder : MonoBehaviour
{
    public void OnClick()
    {
        GetComponent<BoxCollider>().enabled = false;
    }
}
