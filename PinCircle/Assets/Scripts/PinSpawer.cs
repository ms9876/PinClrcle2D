using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinSpawer : MonoBehaviour
{
    [Header("Commons")]
    [SerializeField]
    private GameObject _pinPrefab;

    public void SpawerThrowablePin(Vector3 position)
    {
        //�� ������Ʈ ����
        Instantiate(_pinPrefab, position, Quaternion.identity);
    }
}
