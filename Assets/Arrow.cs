using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//summery === fileProjectile Script
//���ο� �߻��ϴ� ��ũ��Ʈ

public class Arrow : MonoBehaviour
{
    public GameObject arrowGo;

    public Transform  arrowSpawnPosition;

    public Animator animator;

    //������ �ð� �������� projectile �߻�

    public float fireinterval = 0.5f;

    private IEnumerator Start()  //�ð����� �ݺ��ϴ� �Լ�? �ڸ�ƾ �Լ�
    {
        while (true)
        {
            StartCoroutine(OnFireArrow());
            //Instantiate(arrowGo, arrowSpawnPosition.position, transform.rotation);
            yield return new WaitForSeconds(fireinterval); //new�� ������ ���� �� �ٿ�����
        }

        // Update is called once per frame
      
    }



    public float fireDelay = 0.2f;
    public float destroyDelay = 3f;

    private IEnumerator OnFireArrow()
    {
        //����� ����
        animator.Play("Attack01", 0, 0);

        //��� �����ٰ�
        yield return new WaitForSeconds(fireDelay);

        //���ο츦 �߻�
        Instantiate(arrowGo, arrowSpawnPosition.transform.position, transform.rotation);

        //positon�� transformposition���� �ٲ㵵 ��!
    }
}