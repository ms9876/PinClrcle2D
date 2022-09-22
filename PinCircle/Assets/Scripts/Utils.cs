using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils : MonoBehaviour
{
    /// <summary>  
    /// ������ �������� ���� �ѷ� ��ġ�� ����
    /// </summary>
    /// <param name="angle"> ���� </param>
    /// <param name="radius"> ���� ������ </param>
    /// <returns> ���� ������, ������ �ش��ϴ� �ѷ� ��ġ</returns>
    public static Vector3 GetPositionFromAngle(float radius, float angle)
    {
        Vector3 positions = Vector3.zero;

        angle = DegreeToRadian(angle);

        positions.x = Mathf.Cos(angle) * radius;
        positions.y = Mathf.Sin(angle) * radius;

        return positions;
    }

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
