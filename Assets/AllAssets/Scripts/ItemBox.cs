using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    public Slot[] slots; // スロットの配列

    public Slot selectSlot; // アイテムが入ったスロット

    [SerializeField] GameObject backGroundPanel = default;

    public static ItemBox instance;

    private void Awake()
    {
        if (instance == null) {
            instance = this;
        }
    }

    // PickupObjがクリックされたら，スロットにアイテムを入れる
    public void SetItem(Item item)
    {
        foreach (Slot slot in slots) {
            if (slot.IsEmpty()) {
                slot.SetItem(item);
                selectSlot = slot; // selectSlotにアイテムを入れたスロットを格納する
                break;
            }
        }
    }

    // スロットをクリックした時(2回目はbackPanel(白枠)を非表示にする)
    public void OnSlotClick(int position)
    {
        // 選択したところにアイテムがなかったら，何もしない
        if (slots[position].IsEmpty()) {
            return;
        }
        // アイテムzoomPanelが表示されている場合は，何もしない
        if (backGroundPanel.activeSelf == true) {
            return;
        }
        // 2回目のクリック時
        if (slots[position].IsBackPanel() == true) {
            slots[position].HideWhiteBackPanel();
            selectSlot = null;
        } else { // 1回目のクリック時
            // 一度背景を全てのスロットでなくす
            for (int i = 0; i < slots.Length; i++) {
                slots[i].HideBackPanel();
            }
            // クリックしたスロットに背景(白枠 + 黒枠)を入れる
            slots[position].OnSelect();
            // selectSlotをpositionのスロットで保持する
            selectSlot = slots[position];
        }
    }
    
    // 特定のアイテムを選択しているか判定する関数
    public bool CheckSelectItem(Item.Type useItemType)
    {
        if (selectSlot == null) {
            return false;
        }
        if (selectSlot.GetItem().type == useItemType) {
            return true;
        }
        return false;
    }

    public void UseSelectItem()
    {
        selectSlot.RemoveItem();
        selectSlot = null;
    }

    public Item GetSelectItem()
    {
        if (selectSlot == null) {
            return null;
        }
        return selectSlot.GetItem();
    }
}