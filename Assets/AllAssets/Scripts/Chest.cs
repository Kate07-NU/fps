using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    // 鍵を選択の上，クリックされたら宝箱を開ける

    [SerializeField] Animation anim = default;
    [SerializeField] GameObject tile = default;

    void Start()
    {
        // 宝のアイテムを非表示にする
        tile.SetActive(false);
    }

    public void Open()
    {
        if (ItemBox.instance.CheckSelectItem(Item.Type.Key)) {
            anim.Play();
            // 宝のアイテムを表示する
            tile.SetActive(true);
            ItemBox.instance.UseSelectItem();
        }
    }
}
