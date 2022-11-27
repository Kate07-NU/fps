using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetItemText : MonoBehaviour
{
    [SerializeField] Text getItemText;
    [SerializeField, TextArea] string Message = "";

    public void SetGetItemText()
    {
        getItemText.text = Message;
    }
}
