using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearIceKey : MonoBehaviour
{
    [SerializeField] GameObject iceKey = default;
    
    void Start()
    {
        iceKey.SetActive(false);
    }

    public void OnClick()
    {
        iceKey.SetActive(true);
    }
}
