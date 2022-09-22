using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    [SerializeField]
    private GameObject squaer; //���� ���� �κ�
    [SerializeField]
    private float moveTime = 0.2f; // ���� �ϴܿ��� �� 1ȸ �̵� �ð�

    public  void MoveOnStep(float moveDistancce)
    {
        StartCoroutine("MoveTo", moveDistancce);
    }

    public void SetInPinStuctTarget()
    {
        //Throwable Pin���� ���Ǵ� ���� ��� �����̰� ���� ���� �ֱ� ������ �̵� ����
        StopCoroutine("MoveTo");

        //���� ���� Ȱ��ȭ
        squaer.SetActive(true);
    }

    public IEnumerator MoveTo(float moveDistnace)
    {
        Vector3 start = transform.position;
        Vector3 end = transform.position + Vector3.up * moveDistnace;

        float current = 0;
        float percent = 0;

        while ( percent < 1 )
        {
            current += Time.deltaTime;
            percent = current / moveTime;

            transform.position = Vector3.Lerp(start, end, percent);

            yield return null;
        }
    }
}
