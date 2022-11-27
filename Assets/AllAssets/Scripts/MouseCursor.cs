using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseCursor : MonoBehaviour
{
    [SerializeField] GameObject cursorPanel = default;

    private void OnMouseOver()
    {    
        cursorPanel.SetActive(true);
    }

    private void OnMouseExit()
    {
        cursorPanel.SetActive(false);
    }
}
