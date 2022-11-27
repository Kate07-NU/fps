using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialNumber : MonoBehaviour
{
    [SerializeField] TMP_Text numberText; // 表示用
    public int number = 0; // 数字

    // クリックされると数字を増やす
    public void OnClick()
    {
        number++;
        if (number >= 10) {
            number = 0;
        }
        numberText.text = number.ToString();
    }
}