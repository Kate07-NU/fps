using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInformation : MonoBehaviour
{
    // ZoomButtonが押されたら，スロットをItemBoxクラスのselectSlotに渡す

    [SerializeField] Slot slot;

    public void OnClickZoomButton()
    {
        if (slot == null) {
            return;
        }
        // 選択状態(白枠 + 黒枠 + 拡大ボタン)を消す
        for (int i = 0; i < ItemBox.instance.slots.Length; i++) {
            if (ItemBox.instance.slots[i].IsBackPanel() == true) {
                ItemBox.instance.slots[i].HideAll();
            }
        }   
        
        ItemBox.instance.selectSlot = slot;
    }
}