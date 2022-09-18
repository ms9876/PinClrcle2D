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
        //핀 오브젝트 생성
        Instantiate(_pinPrefab, position, Quaternion.identity);
    }
}
