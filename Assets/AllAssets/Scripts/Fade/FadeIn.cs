using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
    [SerializeField] Canvas fadeInCanvas = default;
    
    void Start()
    {
        GetComponent<Animator>().enabled = true;        
    }

    public void HideFadeInCanvas()
    {
        if (fadeInCanvas.gameObject.activeSelf == true) {
            fadeInCanvas.gameObject.SetActive(false);
        }
    }
}
