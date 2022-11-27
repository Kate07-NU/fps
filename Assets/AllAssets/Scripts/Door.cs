using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // 特定のアイテムを取得 かつ 選択状態なら
    // ドアを開ける

    Animation anim = default;
    [SerializeField] GameObject clearPanel = default;

    private void Start()
    {
        clearPanel.SetActive(false);
        anim = GetComponent<Animation>();
    }

    public void Open()
    {
        // 特定のアイテムを選択していたら，ドアを開ける
        if (ItemBox.instance.CheckSelectItem(Item.Type.Key)) { // ドアが開くアイテムを設定する
            ItemBox.instance.UseSelectItem();
            anim.Play();
            clearPanel.SetActive(true);
        }
    }
}