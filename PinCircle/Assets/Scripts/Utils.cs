using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils : MonoBehaviour
{
    /// <summary> ������ �������� ���� �ѷ� ��ġ�� ���� 
    /// 
    public static Vector3 GetPositionFromAngle;

    /// <summary>
    /// 1���� "PI/180" rabian
    /// </summary>
    /// <param name="angle"></param>
    /// <summary>
    public static float DegreeToRadian(float angle)
    {
        return Mathf.PI * angle / 180;
    }

    /// <summary>
    /// Radian ���� Degree ������ ��ȯ
    /// 1radian = "180/PI"�� 
    /// angleRadian�� "180/PI*angle"��
    /// <summary>
    public static float RadianToDegree(float angle)
    {
        return angle * (180 / Mathf.PI);
    }
}
