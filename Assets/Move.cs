using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 0.1f;

    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        //WASD 를 화살표키로 씀
        float moveX = 0;
        float moveZ = 0;

        if (Input.GetKey(KeyCode.UpArrow)) moveZ = 1;
        if (Input.GetKey(KeyCode.DownArrow)) moveZ = -1;

        if (Input.GetKey(KeyCode.LeftArrow)) moveX = -1;
        if (Input.GetKey(KeyCode.RightArrow)) moveX = 1;

        float speed = 0.1f;
        Vector3 position = transform.position;
        position.x = position.x + moveX * speed;
        position.z = position.z + moveZ * speed;


        transform.position = position;

    }
}
