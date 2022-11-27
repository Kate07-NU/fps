using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button3 : MonoBehaviour
{
    [SerializeField] Buttons.BType buttonum;
    GameObject blueman;
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.black;
        blueman = GameObject.Find("LowManSkeleton");
    }

    public void OnClickObj()
    {
        if(GetComponent<Renderer>().material.color == Color.black){
            GetComponent<Renderer>().material.color = Color.yellow;
            blueman.GetComponent<BlueMan>().flag3t();
        }
        else{
            GetComponent<Renderer>().material.color = Color.black;
            blueman.GetComponent<BlueMan>().flag3f();
        }
    }
}
