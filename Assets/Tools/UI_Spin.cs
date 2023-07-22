using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UI_Spin : MonoBehaviour
{
    public void nonAccelerationClockwiseSpin(GameObject obj, int cycleFrame, int nowFrame)
    {
        if(cycleFrame < nowFrame)
        {
            nowFrame = nowFrame % cycleFrame;
        }
        if(nowFrame < 0) 
        {
            Debug.LogError("[UI_Spin.cs/Func: nonAccelerationClockwiseSpin]\tthe (nowFrame) parameter value is below than 0.");
            return;
        }

        float degree = -360.0f * nowFrame / cycleFrame;
        obj.transform.rotation = Quaternion.Euler(0, 0, degree);
    }

    public void nonAccelerationCounterclockwiseSpin(GameObject obj, int cycleFrame, int nowFrame)
    {
        if (cycleFrame < nowFrame)
        {
            nowFrame = nowFrame % cycleFrame;
        }
        if (nowFrame < 0)
        {
            Debug.LogError("[UI_Spin.cs/Func: nonAccelerationCounterclockwiseSpin]\tthe (nowFrame) parameter value is below than 0.");
            return;
        }

        float degree = 360.0f * nowFrame / cycleFrame;
        obj.transform.rotation = Quaternion.Euler(0, 0, degree);
    }

    public void accelerationClockwiseSpin(GameObject obj, int cycleFrame, int nowFrame)
    {
        if (cycleFrame < nowFrame)
        {
            nowFrame = nowFrame % cycleFrame;
        }
        if (nowFrame < 0)
        {
            Debug.LogError("[UI_Spin.cs/Func: accelerationClockwiseSpin]\tthe (nowFrame) parameter value is below than 0.");
            return;
        }

        float degree = -360.0f / (cycleFrame * cycleFrame * cycleFrame * cycleFrame) * (nowFrame * nowFrame) * (nowFrame - 2 * cycleFrame) * (nowFrame - 2 * cycleFrame); //FIXME 다른 함수를 찾아보자

        obj.transform.rotation = Quaternion.Euler(0, 0, degree);
    }

    public void accelerationCounterclockwiseSpin(GameObject obj, int cycleFrame, int nowFrame)
    {
        if (cycleFrame < nowFrame)
        {
            nowFrame = nowFrame % cycleFrame;
        }
        if (nowFrame < 0)
        {
            Debug.LogError("[UI_Spin.cs/Func: accelerationCounterclockwiseSpin]\tthe (nowFrame) parameter value is below than 0.");
            return;
        }

        float degree = -360.0f / (cycleFrame * cycleFrame * cycleFrame * cycleFrame) * (nowFrame * nowFrame) * (nowFrame - 2 * cycleFrame) * (nowFrame - 2 * cycleFrame); //FIXME 다른 함수를 찾아보자

        obj.transform.rotation = Quaternion.Euler(0, 0, degree);
    }

    public void SpinToFewDegree(GameObject obj, float startDegree, float endDegree, int cycleFrame, int nowFrame)
    {
        if (cycleFrame < nowFrame)
        {
            nowFrame = cycleFrame;
        }
        if (nowFrame < 0)
        {
            Debug.LogError("[UI_Spin.cs/Func: SpinToFewDegree]\tthe (nowFrame) parameter value is below than 0.");
            return;
        }

        float turn;
        if(startDegree > endDegree)
        {
            turn = -1.0f * (startDegree - endDegree) / cycleFrame * nowFrame + startDegree;
        }
        else
        {
            turn= 1.0f * (endDegree - startDegree) * (1 - startDegree) / cycleFrame / (1 - startDegree) * nowFrame + startDegree;
        }

        obj.transform.rotation = Quaternion.Euler(0, 0, turn);
    }
}
