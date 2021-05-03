using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//summery
//���ο� �߻��ϴ� ��ũ��Ʈ

public class Arrow : MonoBehaviour
{
    public GameObject arrowGo;

    public Transform  arrowSpawnPosition;

    public Animator animator;

    //������ �ð� �������� projectile �߻�

    public float interval = 0.5f;

    private IEnumerator Start()  //�ð����� �ݺ��ϴ� �Լ�? �ڸ�ƾ �Լ�
    {
        while (true)
        {
            StartCoroutine(OnFireArrow());
            //Instantiate(arrowGo, arrowSpawnPosition.position, transform.rotation);
            yield return new WaitForSeconds(interval); //new�� ������ ���� �� �ٿ�����
        }

        // Update is called once per frame
      
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //OnFireArrow() ;
            StartCoroutine(OnFireArrow());

        }
    }

    public float fireDelay = 0.2f;

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