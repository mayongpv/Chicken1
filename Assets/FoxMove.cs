using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxMove : MonoBehaviour
{
    public Animator animatior;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);

        animatior.Play("Fox_Falling", 0, 0);
    }


}
