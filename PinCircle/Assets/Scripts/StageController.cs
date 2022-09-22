using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour
{
    [SerializeField]
    private PinSpawer pinSpawer; //핀생성을 위한 pinSpawer 컨포넌트
    [SerializeField]
    private int ThrowPinCount; //현재 스테이지를 클리어하기 위해 던져하는 핀 개수
    [SerializeField]
    private int stuckPinCount; //스테이지 시작 사 과녁에 고정되어 있는 핀 개수

    //게임화면 하단에 배치되는 던져야 하는 핀들의 첫 번째 위치
    private Vector3 firstPinPosition = Vector3.down * 2;
    //던져야하는 핀들 사이의 거리
    public float TPinDistance { private get; set; } = 1f;

    private void Awake()
    {
        //PinSpawer의 Setup() 메소드 호출
        pinSpawer.SetUp();

        //게임 하단에 배치되는 던져야 하는 핀 오브젝트 생성 
        for (int i = 0; i < ThrowPinCount; i++)
        {
            pinSpawer.SpawerThrowablePin(firstPinPosition + Vector3.down * TPinDistance * i);
        }

        //게임을 시작할때 과녁에 배치되어 있는 핀 오브젝트 생성
        for(int i = 0; i < stuckPinCount; i++)
        {
            //과녁에 배치되는 핀의 개수에 따라 일정한 간격으로 배치된 때 배치 각도
            float angle = (360 / stuckPinCount) * i;

            pinSpawer.SpawerStuckPin(angle);
        }
    }
}
