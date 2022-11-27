using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObj : MonoBehaviour
{
    [SerializeField] Item.Type itemType; // アイテムの種類
    Item item; // アイテム

    private void Start()
    {
        // itemTypeに応じてitemを生成する
        item = ItemGenerater.instance.Spawn(itemType);
    }
    
    //クリックしたらオブジェクトを消し，ZoomPanelを表示する
    // スロットの場所がわかれば良い
    public void OnClickObj()
    {
        ItemBox.instance.SetItem(item);
        gameObject.SetActive(false);
        ZoomPanel.instance.OnClickZoom();
        ItemBox.instance.selectSlot = null;
    }
}
