using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    // 鍵を選択の上，クリックされたら宝箱を開ける

    [SerializeField] Animation anim = default;

    public void Open()
    {
        if (ItemBox.instance.CheckSelectItem(Item.Type.Key)) {
            anim.Play();
            ItemBox.instance.UseSelectItem();
        }
    }
}
