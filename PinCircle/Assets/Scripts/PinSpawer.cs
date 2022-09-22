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
        // ���� ���� ���� �÷��̾ ���콺 ���� Ŭ������ ����
        if(Input.GetMouseButtonDown(0) && throwablePins.Count > 0)  
        {
            // ThrowablePins ����Ʈ�� ����� ù ��° ���� ���ῡ ��ġ
            SetInPinStuckToTarget(throwablePins[0].transform, bottomAngle);
            // ��� ���ῡ ��ġ�� ù ��° �� ��Ҹ� ����ũ���� ����
            throwablePins.RemoveAt(0);

            //���ῡ ��ġ���� �ʴ� throwablePins ����Ʈ�� ��� �� ��ġ �̵�
            for(int i = 0; i < throwablePins.Count; ++i)
            {
               // throwablePins[i].MoveOnStep(stageController.TPinDistance);
               // �̰� ���� �� ������� �𸣰����ϱ� �ٽ� �� �����غ���
            }
        }
    }

    public void SpawerThrowablePin(Vector3 position)
    {
        //�� ������Ʈ ����
        GameObject clone = Instantiate(_pinPrefab, position, Quaternion.identity);

        // "pin" ������Ʈ ������ ���� SetUp() �޼ҵ� ȣ��
        Pin pin = clone.GetComponent<Pin>();

        // ��� ������ �� ������Ʈ�� "Pin" ������Ʈ�� ����Ʈ�� �߰�
        throwablePins.Add(pin);
    }

    public void SpawerStuckPin(float angle)
    {
        //�� ������Ʈ ����
        GameObject clone = Instantiate(_pinPrefab); 

        //�� ���ῡ ��ġ�� �� �ֵ��� ����
        SetInPinStuckToTarget(clone.transform, angle);  
    }

    private void SetInPinStuckToTarget(Transform pin, float angle)
    {
        //Ÿ���� �ش��ϴ� ������ ���� ������ �� ��ġ
        pin.position = Utils.GetPositionFromAngle(tragetRadius + PinLength, angle) + tragetPosition;
        //�� ������Ʈ ȸ�� ����
        pin.rotation = Quaternion.Euler(0, 0, angle);
        //�� ������Ʈ�� traget�� �ڽ����� �����ؼ� traget�� ���� ȸ���ϵ��� �Ѵ�.
        pin.SetParent(tragetTransfrom);
        //���� ���ῡ ��ġ�Ǿ��� �� ����
        pin.GetComponent<Pin>().SetInPinStuctTarget();
    }
}
