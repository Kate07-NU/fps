using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CursorPanel : MonoBehaviour
{
    [SerializeField] Slot slot; // 親スロット
    [SerializeField] GameObject cursorPanel = default; // 黒枠
    [SerializeField] GameObject zoomButton = default; // 拡大ボタン
    [SerializeField] GameObject backGroundPanel = default; // アイテムzoomPanel

    // マウスカーソルが重なったとき
    public void OnMouseOver()
    {
        if (slot.IsEmpty()) { // スロットに何も入っていなかったとき
            return;
        }
        if (backGroundPanel.activeSelf == true) {
            cursorPanel.SetActive(false);
            zoomButton.SetActive(false);
        } else {
            if (slot.IsBackPanel() == true) { // BackPanel(白枠)が表示されているとき
                zoomButton.SetActive(true);
            } else if (slot.IsBackPanel() == false) { // BackPanel(白枠)が表示されていないとき
                cursorPanel.SetActive(true);
                zoomButton.SetActive(true);
            }
        }
    }

    // マウスカーソルが離れたとき
    public void OnMouseExit()
    {
        if (slot.IsEmpty()) { // スロットに何も入っていなかったとき
            return;
        }
        if (backGroundPanel.activeSelf == true) {
            cursorPanel.SetActive(false);
            zoomButton.SetActive(false);
        } else {
             if (slot.IsBackPanel() == true) { // BackPanel(白枠)が表示されているとき
                zoomButton.SetActive(false);
            } else if (slot.IsBackPanel() == false) { // BackPanel(白枠)が表示されていないとき
                cursorPanel.SetActive(false);
                zoomButton.SetActive(false);
            }
        }
    }
}