using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinSpawer : MonoBehaviour
{
    [Header("Commons")]
    [SerializeField]
    private StageController stageController;
    [SerializeField]
    private GameObject _pinPrefab;

    [Header("Stuck Pin")]
    [SerializeField]
    private Transform tragetTransfrom;
    [SerializeField]
    private Vector3 tragetPosition = Vector3.up * 2;
    [SerializeField]
    private float tragetRadius = 0.8f;
    [SerializeField]
    private float PinLength = 1.5f;

    [Header("Throwable Pin")]
    [SerializeField]
    private float bottomAngle = 270;
    private List<Pin> throwablePins;    

    public void SetUp()
    {
        throwablePins = new List<Pin>(); 
    }

    private void Update()
    {
        // 게임 진행 도중 플레이어가 마우스 왼쪽 클릭으로 생성
        if(Input.GetMouseButtonDown(0) && throwablePins.Count > 0)  
        {
            // ThrowablePins 리스트에 저장된 첫 번째 핀을 과녁에 배치
            SetInPinStuckToTarget(throwablePins[0].transform, bottomAngle);
            // 방금 과녁에 배치한 첫 번째 핀 요소를 리스크에서 삭제
            throwablePins.RemoveAt(0);

            //과녁에 배치되지 않는 throwablePins 리스트의 모든 핀 위치 이동
            for(int i = 0; i < throwablePins.Count; ++i)
            {
               // throwablePins[i].MoveOnStep(stageController.TPinDistance);
               // 이거 오류 왜 생기는지 모르겠으니까 다시 잘 생각해볼것
            }
        }
    }

    public void SpawerThrowablePin(Vector3 position)
    {
        //핀 오브젝트 생성
        GameObject clone = Instantiate(_pinPrefab, position, Quaternion.identity);

        // "pin" 컴포넌트 정보를 얻어와 SetUp() 메소드 호출
        Pin pin = clone.GetComponent<Pin>();

        // 방금 생성한 핀 오브젝트를 "Pin" 컴포넌트를 리스트에 추가
        throwablePins.Add(pin);
    }

    public void SpawerStuckPin(float angle)
    {
        //핀 오브젝트 생성
        GameObject clone = Instantiate(_pinPrefab); 

        //핀 과녁에 배치될 수 있도록 설정
        SetInPinStuckToTarget(clone.transform, angle);  
    }

    private void SetInPinStuckToTarget(Transform pin, float angle)
    {
        //타겟의 해당하는 각도에 핀이 꽂혔을 때 위치
        pin.position = Utils.GetPositionFromAngle(tragetRadius + PinLength, angle) + tragetPosition;
        //핀 오브젝트 회전 설정
        pin.rotation = Quaternion.Euler(0, 0, angle);
        //핀 오브젝트를 traget의 자식으로 설정해서 traget과 같이 회전하도록 한다.
        pin.SetParent(tragetTransfrom);
        //핀이 과녁에 배치되었을 때 설정
        pin.GetComponent<Pin>().SetInPinStuctTarget();
    }
}
