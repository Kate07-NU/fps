using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItemPanel : MonoBehaviour
{
    [SerializeField] GameObject backPanel = default;
    [SerializeField] GameObject itemBoxPanel = default;

    public void ShowGetItemPanel()
    {
        itemBoxPanel.SetActive(false);
        backPanel.SetActive(true);
    }

    public void HideGetItemPanel()
    {
        itemBoxPanel.SetActive(true);
        backPanel.SetActive(false);
    }
}