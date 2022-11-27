using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unzip : MonoBehaviour
{
    [SerializeField] Slot[] slots; // スロットの配列
    [SerializeField] Item item; // Keyアイテム
    
    // 壺がクリックされたら，Keyをアイテムとして取得する
    public void ClickVase()
    {
        if (ItemBox.instance.CheckSelectItem(Item.Type.IceKey)) {
            ItemBox.instance.UseSelectItem();
            foreach (Slot slot in slots) {
                if (slot.IsEmpty()) {
                    slot.SetItem(item);
                    break;
                }
            }
        }
    }
}
