using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    //�Q�[���I�u�W�F�N�g���C���X�x�N�^�[����Q�Ƃ��邽�߂̕ϐ�
    public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�e�𐶐�����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //��������0.01����
            Instantiate(Bullet,transform.position,Quaternion.identity);
        }
    }
}
