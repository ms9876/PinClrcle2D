using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour
{
    [SerializeField]
    private PinSpawer pinSpawer; //�ɻ����� ���� pinSpawer ������Ʈ
    [SerializeField]
    private int ThrowPinCount; //���� ���������� Ŭ�����ϱ� ���� �����ϴ� �� ����

    //����ȭ�� �ϴܿ� ��ġ�Ǵ� ������ �ϴ� �ɵ��� ù ��° ��ġ
    private Vector3 firstPinPosition = Vector3.down * 2;
    //�������ϴ� �ɵ� ������ �Ÿ�
    public float TPinDistance { private get; set; } = 1f;

    private void Awake()
    {
        //���� �ϴܿ� ��ġ�Ǵ� ������ �ϴ� �� ������Ʈ ���� 
        for (int i = 0; i < ThrowPinCount; i++)
        {
            pinSpawer.SpawerThrowablePin(firstPinPosition + Vector3.down * TPinDistance * i);
        }

    }
}
