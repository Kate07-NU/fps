using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnTV : MonoBehaviour
{
    // EventTriggerでクリックして，リモコンを持っていた場合のみテレビをつけることができる．

    [SerializeField] Sprite beforeImage = default;
    [SerializeField] Sprite FirstImage = default;
    [SerializeField] Sprite SecondImage = default;
    [SerializeField] Sprite ThirdImage = default;
    [SerializeField] Sprite FourthImage = default;
    [SerializeField] Sprite FifthImage = default;

    SpriteRenderer tvImage;

    public void Start()
    {
        tvImage = GetComponent<SpriteRenderer>();
        tvImage.sprite = beforeImage;
    }

    public void ClickTV()
    {
        if (ItemBox.instance.CheckSelectItem(Item.Type.RemoteController)) {
            // リモコンを持っている場合，TVつける
            if (tvImage.sprite == null) {
                tvImage.sprite = beforeImage;
            } else if (tvImage.sprite == beforeImage) {
                tvImage.sprite = FirstImage;  
            } else if (tvImage.sprite == FirstImage) {
                tvImage.sprite = SecondImage;
            } else if (tvImage.sprite == SecondImage) {
                tvImage.sprite = ThirdImage;
            } else if (tvImage.sprite == ThirdImage) {
                tvImage.sprite = FourthImage;
            } else if (tvImage.sprite == FourthImage) {
                tvImage.sprite = FifthImage;
            } else {
                tvImage.sprite = beforeImage;
            }
        }
    }
}
