using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    [SerializeField]
    private GameObject squaer;

    public void SetInPinStuctTarget()
    {
        //���� ���� Ȱ��ȭ
        squaer.SetActive(true);
    }
}
