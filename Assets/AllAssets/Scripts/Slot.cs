using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    [SerializeField] GameObject backPanel = default; // 白枠
    [SerializeField] GameObject cursorPanel = default; // 黒枠
    Item item = null; // アイテム
    [SerializeField] Image image = default; // 画像
    [SerializeField] GameObject zoomButton = default; // 拡大ボタン
    
    private void Start()
    {
        backPanel.SetActive(false);
        cursorPanel.SetActive(false);
        zoomButton.SetActive(false);
    }

    public bool IsEmpty()
    {
        if (item == null) {
            return true;
        }
        return false;
    }

    public void SetItem(Item item)
    {
        this.item = item;
        UpdateImage(item);
    }

    public void RemoveItem()
    {
        item = null;
        image.sprite = null;
        HideBackPanel();

    }

    void UpdateImage(Item item)
    {
        image.sprite = item.sprite;
    }

    public Item GetItem()
    {
        return item;
    }

    public void OnSelect()
    {
        backPanel.SetActive(true);
        cursorPanel.SetActive(true);
    }

    public void HideBackPanel()
    {
        backPanel.SetActive(false);
        cursorPanel.SetActive(false);
    }

    public void HideWhiteBackPanel()
    {
        backPanel.SetActive(false);
    }

    public void HideAll()
    {
        backPanel.SetActive(false);
        cursorPanel.SetActive(false);
        zoomButton.SetActive(false);
    }

    public bool IsBackPanel()
    {
        if (backPanel.activeSelf == false) {
            return false;
        }
        return true;
    }
}