using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    //ゲームオブジェクトをインスベクターから参照するための変数
    public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //弾を生成する
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //下方向に0.01動く
            Instantiate(Bullet,transform.position,Quaternion.identity);
        }
    }
}
