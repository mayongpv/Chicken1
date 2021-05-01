using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//summery
//에로우 발사하는 스크립트

public class Arrow : MonoBehaviour
{
    public GameObject arrowGO;

    public GameObject arrowSpawnPosition;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //에로우를 발사
            Instantiate(arrowGO, transform.position, transform.rotation);

        }
    }
}
