using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    [SerializeField]
    private GameObject squaer;

    public void SetInPinStuctTarget()
    {
        //핀의 막대 활성화
        squaer.SetActive(true);
    }
}
