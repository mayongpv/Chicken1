

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 0.1f;

    public Animatior animatior;

    // Start is called before the first frame update
    
    // Update is called once per frame
    public void Update()
    {
        //WASD 를 화살표키로 씀
        float moveX = 0;
        float moveZ = 0;

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) moveZ = 1;
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) moveZ = -1;

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) moveX = -1;
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) moveX = 1;

        Vector3 position = transform.position;
        position.x = position.x + moveX * speed * Time.deltaTime;
        position.z = position.z + moveZ * speed * Time.deltaTime;
        transform.position = position;

        //if (animatior.GetCurrentAnimatiorStateInfo(0).IsName("Attact01") == false)
        //{
        //    if (moveX != 0 || moveZ != 0)
        //        animatior.Play("RunForwardBattle");
        //    else
        //        animatior.Play("Idle_Battle");
        //}

    }
}
