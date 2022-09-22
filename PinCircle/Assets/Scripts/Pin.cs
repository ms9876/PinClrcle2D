using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    [SerializeField]
    private GameObject squaer; //핀의 막대 부분
    [SerializeField]
    private float moveTime = 0.2f; // 게임 하단에서 핀 1회 이동 시간

    public  void MoveOnStep(float moveDistancce)
    {
        StartCoroutine("MoveTo", moveDistancce);
    }

    public void SetInPinStuctTarget()
    {
        //Throwable Pin으로 사용되던 판의 경우 움직이고 있을 수도 있기 때문에 이동 중지
        StopCoroutine("MoveTo");

        //핀의 막대 활성화
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
