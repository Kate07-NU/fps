using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomPanel : MonoBehaviour
{
    // クリックしてズームパネルの表示

    [SerializeField] GameObject zoomPanel; // ZoomCanvasの子
    [SerializeField] Transform zoomObjParent; // 空のオブジェクト
    GameObject zoomItem; // (プレハブ化した)ズームするアイテム

    public static ZoomPanel instance;

    private void Awake()
    {
        if (instance == null) {
            instance = this;
        }
    }
    
    public void OnClickZoom()
    {
        Item selectItem = ItemBox.instance.GetSelectItem();
        if (selectItem == null) {
            return;
        }
        zoomPanel.SetActive(true);
        ShowItem();
    }

    void ShowItem() // zoomするアイテムを空のオブジェクトの子として表示する
    {
        // 選択中のアイテムを表示する
        // 表示する = データベースから生成する
        if (zoomItem != null) {
            Destroy(zoomItem);
        }
        Item selectItem = ItemBox.instance.GetSelectItem();
        zoomItem = ItemGenerater.instance.CreateZoomItem(selectItem.type);
        zoomItem.transform.SetParent(zoomObjParent, false);
        ItemBox.instance.selectSlot = null; // zoom終了時には，selectSlotをnullにする
    }

    public void HideZoomPanel()
    {
        zoomPanel.SetActive(false);
    }
}