using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookUpPanel : MonoBehaviour
{
    [SerializeField] GameObject lookUpPanel;

    public void ShowLookUpPanel()
    {
        lookUpPanel.SetActive(true);
    }

    public void HideLookUpPanel()
    {
        lookUpPanel.SetActive(false);
    }
}
