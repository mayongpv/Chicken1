using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//summery === fileProjectile Script
//에로우 발사하는 스크립트

public class Arrow : MonoBehaviour
{
    public GameObject arrowGo;

    public Transform  arrowSpawnPosition;

    public Animator animator;

    //지정한 시간 간격으로 projectile 발사

    public float fireinterval = 0.5f;

    private IEnumerator Start()  //시간동안 반복하는 함수? 코르틴 함수
    {
        while (true)
        {
            StartCoroutine(OnFireArrow());
            //Instantiate(arrowGo, arrowSpawnPosition.position, transform.rotation);
            yield return new WaitForSeconds(fireinterval); //new를 빼먹지 말고 꼭 붙여야함
        }

        // Update is called once per frame
      
    }



    public float fireDelay = 0.2f;
    public float destroyDelay = 3f;

    private IEnumerator OnFireArrow()
    {
        //어탣엑션 진행
        animator.Play("Attack01", 0, 0);

        //잠시 쉬었다가
        yield return new WaitForSeconds(fireDelay);

        //에로우를 발사
        Instantiate(arrowGo, arrowSpawnPosition.transform.position, transform.rotation);

        //positon을 transformposition으로 바꿔도 됨!
    }
}