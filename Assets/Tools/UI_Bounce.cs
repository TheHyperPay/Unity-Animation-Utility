using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Bounce : MonoBehaviour
{
    //startPoint: the start point of the UI object
    //peak: the peak of the bounce(relative value)
    //cycleFrame: 1 cycle(1 bounce) per frames
    //nowFrame: the current frame
    public float valticalityUpMovement(float startYPoint, float peak, int cycleFrame, int nowFrame)
    {
        if (cycleFrame < nowFrame) 
        {
            Debug.LogError("[UI_Bounce.cs/Func: valticalityUpMovement]\tthe (nowFrame) parameter is bigger than (cycleFrame) parameter.");
            return startYPoint; 
        }
        if (nowFrame < 0) 
        {
            Debug.LogError("[UI_Bounce.cs/Func: valticalityUpMovement]\tthe (nowFrame) parameter value is below than 0.");
            return startYPoint; 
        }

        return -1 * peak / (cycleFrame * cycleFrame / 4) * (nowFrame - cycleFrame / 2) * (nowFrame - cycleFrame / 2) + peak + startYPoint;
    }



    public float inerticaUpMovement(float startYPos, float relativeEndYPos, int cycleFrame, int nowFrame)
    {
        if (cycleFrame < nowFrame)
        {
            Debug.LogError("[UI_Bounce.cs/Func: inerticaUpMovement]\tthe (nowFrame) parameter is bigger than (cycleFrame) parameter.");
            return relativeEndYPos + startYPos;
        }
        if (nowFrame < 0)
        {
            Debug.LogError("[UI_Bounce.cs/Func: inerticaUpMovement]\tthe (nowFrame) parameter value is below than 0.");
            return startYPos;
        }

        return 1.0f * relativeEndYPos / cycleFrame * nowFrame + startYPos;
    }

    public float inerticaDownMovement(float startYPos, float relativeEndYPos, int cycleFrame, int nowFrame)
    {
        if (cycleFrame < nowFrame)
        {
            Debug.LogError("[UI_Bounce.cs/Func: inerticaUpMovement]\tthe (nowFrame) parameter is bigger than (cycleFrame) parameter.");
            return relativeEndYPos + startYPos;
        }
        if (nowFrame < 0)
        {
            Debug.LogError("[UI_Bounce.cs/Func: inerticaUpMovement]\tthe (nowFrame) parameter value is below than 0.");
            return startYPos;
        }

        return -1.0f * relativeEndYPos / cycleFrame * nowFrame + startYPos;
    }
}
