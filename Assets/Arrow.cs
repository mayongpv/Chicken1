using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//summery
//���ο� �߻��ϴ� ��ũ��Ʈ

public class Arrow : MonoBehaviour
{
    public GameObject arrowGO;

    public GameObject arrowSpawnPosition;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //���ο츦 �߻�
            Instantiate(arrowGO, transform.position, transform.rotation);

        }
    }
}
