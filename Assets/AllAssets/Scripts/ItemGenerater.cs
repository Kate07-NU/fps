using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerater : MonoBehaviour
{
    [SerializeField] ItemListEntity itemListEntity;

    public static ItemGenerater instance;
    private void Awake()
    {
        if (instance == null) {
            instance = this;
        }
    }

    public Item Spawn(Item.Type type)
    {
        // itemListの中からtypeと一致したら同じitemを生成して渡す
        foreach (Item item in itemListEntity.itemList) {
            if (item.type == type) {
                return new Item(item.type, item.sprite);
            }
        }
        return null;
    }

    // ズームアイテムを生成する
    public GameObject CreateZoomItem(Item.Type itemType)
    {
        for (int i = 0; i < itemListEntity.itemList.Count; i++) {
            Item itemData = itemListEntity.itemList[i];
            // データベースの中からTypeの一致するものを探す
            if (itemData.type == itemType) {
                // 一致したら，Itemを生成して渡す
                return Instantiate(itemData.zoomPrefab);
            }
        }
        return null;
    }
}