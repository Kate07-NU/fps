using System;
using UnityEngine;

[Serializable]
public class Item
{
    // アイテムの種類を列挙する
    public enum Type
    {
        Cube,
        Ball,
        Key,
        Apple,
        RemoteController,
        IceKey,
        Memo,
    }

    public Type type; // 種類
    public Sprite sprite; // slotに表示する画像
    public GameObject zoomPrefab; // ズーム時に表示するためのPrefab

    public Item(Type type, Sprite sprite)
    {
        this.type = type;
        this.sprite = sprite;
    }
}