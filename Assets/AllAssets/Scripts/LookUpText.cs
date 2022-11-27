using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LookUpText : MonoBehaviour
{
    [SerializeField] Text lookUpText;
    [SerializeField, TextArea] string Message = "";

    public void SetLookUpText()
    {
        lookUpText.text = Message;
    }
}