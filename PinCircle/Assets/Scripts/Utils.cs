using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils : MonoBehaviour
{
    /// <summary>  
    /// 각도를 기준으로 원의 둘레 위치를 구함
    /// </summary>
    /// <param name="angle"> 각도 </param>
    /// <param name="radius"> 원의 반지름 </param>
    /// <returns> 원의 반지름, 각도에 해당하는 둘레 위치</returns>
    public static Vector3 GetPositionFromAngle(float radius, float angle)
    {
        Vector3 positions = Vector3.zero;

        angle = DegreeToRadian(angle);

        positions.x = Mathf.Cos(angle) * radius;
        positions.y = Mathf.Sin(angle) * radius;

        return positions;
    }

    /// <summary>
    /// 1도는 "PI/180" rabian
    /// </summary>
    /// <param name="angle"></param>
    /// <summary>
    public static float DegreeToRadian(float angle)
    {
        return Mathf.PI * angle / 180;
    }

    /// <summary>
    /// Radian 값을 Degree 값으로 변환
    /// 1radian = "180/PI"도 
    /// angleRadian은 "180/PI*angle"도
    /// <summary>
    public static float RadianToDegree(float angle)
    {
        return angle * (180 / Mathf.PI);
    }
}
