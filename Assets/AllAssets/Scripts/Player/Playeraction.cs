using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playeraction : MonoBehaviour
{
    Vector3 MOVEX = new Vector3(1.0f, 0, 0); // x軸方向に１マス移動するときの距離
    Vector3 MOVEZ = new Vector3(0, 0, 1.0f); // z軸方向に１マス移動するときの距離
 
    float step = 5f;     // 移動速度
    Vector3 target;      // 入力受付時、移動後の位置を算出して保存
    Vector3 prevPos;     // 何らかの理由で移動できなかった場合、元の位置に戻すため移動前の位置を保存

    bool coroutineBool = false;

    int count=0;

    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // ① 移動中かどうかの判定。移動中でなければ入力を受付
        if (transform.position == target) {
            SetTargetPosition ();
        }
        Move ();
    }
 
    // ② 入力に応じて移動後の位置を算出
    void SetTargetPosition(){
        prevPos = target;
 
        if (Input.GetKey (KeyCode.D)){
            //if(count % 4 == 0){
            //target = transform.position + MOVEX;
            //}else if((count % 4 == 1 && count > 0) || (count % 4 == 3 && count < 0)){
            //target = transform.position - MOVEZ;
            //}else if(count % 4 == 2){
            //target = transform.position - MOVEX;
            //}else{
            //target = transform.position + MOVEZ;
            //}
            //回転中ではない場合は実行
            if (!coroutineBool)
            {
                coroutineBool = true;
                StartCoroutine("RightMove");
                count++;
            }
            return;
        }
        if (Input.GetKey (KeyCode.A)) {
            //if(count % 4 == 0){
            //target = transform.position - MOVEX;
            //}else if((count % 4 == 1 && count > 0) || (count % 4 == 3 && count < 0)){
            //target = transform.position - MOVEZ;
            //}else if(count % 4 == 2){
            //target = transform.position + MOVEX;
            //}else{
            //target = transform.position + MOVEZ;
            //}
             //回転中ではない場合は実行
            if (!coroutineBool)
            {
                coroutineBool = true;
                StartCoroutine("LeftMove");
                count--;
             }
            return;
        }
        if (Input.GetKey (KeyCode.W)) {
            if(count % 4 == 0){
            target = transform.position + MOVEZ;
            }else if((count % 4 == 1 && count > 0) || (count % 4 == 3 && count < 0)){
            target = transform.position + MOVEX;
            }else if(count % 4 == 2){
            target = transform.position - MOVEZ;
            }else{
            target = transform.position - MOVEX;
            }
            return;
        }
        if (Input.GetKey (KeyCode.S)) {
            if(count % 4 == 0){
            target = transform.position - MOVEZ;
            }else if((count % 4 == 1 && count > 0) || (count % 4 == 3 && count < 0)){
            target = transform.position - MOVEX;
            }else if(count % 4 == 2){
            target = transform.position + MOVEZ;
            }else{
            target = transform.position + MOVEX;
            }
            return;
        }
    }
 
    // ③ 目的地へ移動する
    void Move(){
        transform.position = Vector3.MoveTowards (transform.position, target, step * Time.deltaTime);
    }
 
     //右にゆっくり回転して90°でストップ
    IEnumerator RightMove()
    {
        for (int turn=0; turn<90; turn++)
        {
            transform.Rotate(0,1,0);
            yield return new WaitForSeconds(0.01f);
        }
        coroutineBool = false;
    }
 
    //左にゆっくり回転して90°でストップ
    IEnumerator LeftMove()
    {
        for (int turn=0; turn<90; turn++)
        {
            transform.Rotate(0,-1,0);
            yield return new WaitForSeconds(0.01f);
        }
        coroutineBool = false;
    }
}