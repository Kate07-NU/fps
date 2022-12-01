using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueMan : MonoBehaviour
{
   Animator animB;
   Animation left, right;
   public bool buttonflag1;
   public bool buttonflag2;
   public bool buttonflag3;
   public bool buttonflag4;
   public bool buttonflag5;
   public bool buttonflag6;
   [SerializeField] GameObject leftDoor = default;
   [SerializeField] GameObject rightDoor = default;
   [SerializeField] Camera subOpenCamera = default;
   [SerializeField] Camera subPanelCamera = default;
   [SerializeField] GameObject backPanel = default;

   bool isSlide = false; // スライドしたかどうかを示す変数

   public void Start()
    {
        animB = GetComponent<Animator>(); 
        left = leftDoor.GetComponent<Animation>();
        right = rightDoor.GetComponent<Animation>();
        buttonflag1 = false;
        buttonflag2 = false;
        buttonflag3 = false;
        buttonflag4 = false;
        buttonflag5 = false;
        buttonflag6 = false;
        subOpenCamera.gameObject.SetActive(false);
    }

    public void flag1t()
    {
        buttonflag1 = true;
        // Debug.Log("1 = true");
    }

    public void flag2t()
    {
        buttonflag2 = true;
    }

    public void flag3t()
    {
        buttonflag3 = true;
    }

    public void flag4t()
    {
        buttonflag4 = true;
    }

    public void flag5t()
    {
        buttonflag5 = true;
    }

    public void flag6t()
    {
        buttonflag6 = true;
    }

    public void flag1f()
    {
        buttonflag1 = false;
    }

    public void flag2f()
    {
        buttonflag2 = false;
    }

    public void flag3f()
    {
        buttonflag3 = false;
    }

    public void flag4f()
    {
        buttonflag4 = false;
    }

    public void flag5f()
    {
        buttonflag5 = false;
    }

    public void flag6f()
    {
        buttonflag6 = false;
    }

    void Update()
    {
        if(buttonflag1 == true){
            if(buttonflag2 == false){
                if(buttonflag3 == false){
                    if(buttonflag4 == true){
                        if(buttonflag5 == false){
                            if(buttonflag6 == true){
                                if (isSlide == false) { // 一回のみLowManをSlideする
                                    isSlide = true;
                                    backPanel.SetActive(false);
                                    subPanelCamera.gameObject.SetActive(false);
                                    subOpenCamera.gameObject.SetActive(true);
                                    animB.SetBool("banim", true);
                                    left.Play();
                                    right.Play();
                                }
                                return;        
                            }
                        }
                    }
                }
            }
        }
    }
}
