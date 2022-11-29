using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasswordPanel : MonoBehaviour
{
    // パスワード
    int[] correctAnswer = {0, 4, 2, 2};
    [SerializeField] DialNumber[] dialNumbers = default;
    [SerializeField] GameObject leftDoor = default;
    [SerializeField] GameObject rightDoor = default;
    [SerializeField] Camera subPasswordCamera = default;
    [SerializeField] Camera subOpenCamera = default;
    [SerializeField] GameObject backPanel = default;

    Animation animL = default;
    Animation animR = default; 
    public void Start()
    {
        animL = leftDoor.GetComponent<Animation>();       
        animR = rightDoor.GetComponent<Animation>();    
        subOpenCamera.gameObject.SetActive(false);   
    }
    // パスワードとユーザの入力を確かめる
    public void OnClickButton()
    {
        if (CheckClear()) {
            // ドアを開ける
            backPanel.SetActive(false);
            subPasswordCamera.gameObject.SetActive(false);
            subOpenCamera.gameObject.SetActive(true);
            animL.Play();
            animR.Play();
        }
    }

    // パスワードが一致するかどうか確認する
    bool CheckClear()
    {
        for (int i = 0; i < dialNumbers.Length; i++) {
            if (dialNumbers[i].number != correctAnswer[i]) {
                return false;
            }
        }
        return true;
    }
}