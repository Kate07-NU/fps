using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    // 鍵を選択の上，クリックされたら宝箱を開ける

    [SerializeField] Animation anim = default;

    void Start()
    {
        // 最初は宝のアイテムを非表示にする
    }

    public void Open()
    {
        if (ItemBox.instance.CheckSelectItem(Item.Type.Key)) {
            anim.Play();
            // ここで宝のアイテムを表示する
            ItemBox.instance.UseSelectItem();
        }
    }
}
