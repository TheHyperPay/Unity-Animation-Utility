using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Scale : MonoBehaviour
{
    //setting Object's Scale
    public void scaleUpYAxisTo1(RectTransform rectTransform, float startSize, int cycleFrame, int nowFrame)
    {
        if (cycleFrame < nowFrame)
        {
            nowFrame = cycleFrame;
        }
        if (nowFrame < 0)
        {
            Debug.LogError("[UI_Scale.cs/Func: scaleUpYAxisTo1]\tthe (nowFrame) parameter value is below than 0.");
            return;
        }
        if (startSize > 1f || startSize < 0f)
        {
            Debug.LogError("[UI_Scale.cs/Func: scaleUpYAxisTo1]\tthe (startSize) parameter value is not between 0 to 1.");
            return;
        }

        float scale = 1.0f * (1 - startSize) / cycleFrame * nowFrame + startSize;

        Vector3 newScale = rectTransform.localScale;
        newScale.y = scale;
        rectTransform.localScale = newScale;
    }

    public void scaleUpXAxisTo1(RectTransform rectTransform, float startSize, int cycleFrame, int nowFrame)
    {
        if (cycleFrame < nowFrame)
        {
            nowFrame = cycleFrame;
        }
        if (nowFrame < 0)
        {
            Debug.LogError("[UI_Scale.cs/Func: scaleUpXAxisTo1]\tthe (nowFrame) parameter value is below than 0.");
            return;
        }
        if (startSize > 1f || startSize < 0f)
        {
            Debug.LogError("[UI_Scale.cs/Func: scaleUpXAxisTo1]\tthe (startSize) parameter value is not between 0 to 1.");
            return;
        }

        float scale = 1.0f * (1 - startSize) / cycleFrame * nowFrame + startSize;

        Vector3 newScale = rectTransform.localScale;
        newScale.x = scale;
        rectTransform.localScale = newScale;
    }

    public void scaleChangeYAxisToEndSize(RectTransform rectTransform, float startSize, float endSize, int cycleFrame, int nowFrame)
    {
        if (cycleFrame < nowFrame)
        {
            nowFrame = cycleFrame;
        }
        if (nowFrame < 0)
        {
            Debug.LogError("[UI_Scale.cs/Func: scaleChangeYAxisToEndSize]\tthe (nowFrame) parameter value is below than 0.");
            return;
        }

        float scale;

        if (startSize > endSize) 
        {
            scale = -1.0f * (startSize - endSize) / cycleFrame * nowFrame + startSize;
        }
        else
        {
            scale = 1.0f * (endSize - startSize) * (1 - startSize) / cycleFrame / (1 - startSize) * nowFrame + startSize;
        }

        Vector3 newScale = rectTransform.localScale;
        newScale.y = scale;
        rectTransform.localScale = newScale;
    }

    public void scaleChangeXAxisToEndSize(RectTransform rectTransform, float startSize, float endSize, int cycleFrame, int nowFrame)
    {
        if (cycleFrame < nowFrame)
        {
            nowFrame = cycleFrame;
        }
        if (nowFrame < 0)
        {
            Debug.LogError("[UI_Scale.cs/Func: scaleChangeXAxisToEndSize]\tthe (nowFrame) parameter value is below than 0.");
            return;
        }

        float scale;

        if (startSize > endSize)
        {
            scale = -1.0f * (startSize - endSize) / cycleFrame * nowFrame + startSize;
        }
        else
        {
            scale = 1.0f * (endSize - startSize) * (1 - startSize) / cycleFrame / (1 - startSize) * nowFrame + startSize;
        }

        Vector3 newScale = rectTransform.localScale;
        newScale.x = scale;
        rectTransform.localScale = newScale;
    }


    public void scaleChangeWidthToEndWidth(RectTransform rectTransform, float startWidth, float endWidth, int cycleFrame, int nowFrame)
    {
        if (cycleFrame < nowFrame)
        {
            nowFrame = cycleFrame;
        }
        if (nowFrame < 0)
        {
            Debug.LogError("[UI_Scale.cs/Func: scaleChangeWidthToEndWidth]\tthe (nowFrame) parameter value is below than 0.");
            return;
        }

        float scale;

        if (startWidth > endWidth)
        {
            scale = -1.0f * (startWidth - endWidth) / cycleFrame * nowFrame + startWidth;
        }
        else
        {
            scale = 1.0f * (endWidth - startWidth) * (1 - startWidth) / cycleFrame / (1 - startWidth) * nowFrame + startWidth;
        }

        Vector2 width = rectTransform.sizeDelta;
        width.x = scale;
        rectTransform.sizeDelta = width;
    }

    public void scaleChangeHeightToEndHeight(RectTransform rectTransform, float startHeight, float endHeight, int cycleFrame, int nowFrame)
    {
        if (cycleFrame < nowFrame)
        {
            nowFrame = cycleFrame;
        }
        if (nowFrame < 0)
        {
            Debug.LogError("[UI_Scale.cs/Func: scaleChangeHeightToEndHeight]\tthe (nowFrame) parameter value is below than 0.");
            return;
        }

        float scale;

        if (startHeight > endHeight)
        {
            scale = -1.0f * (startHeight - endHeight) / cycleFrame * nowFrame + startHeight;
        }
        else
        {
            scale = 1.0f * (endHeight - startHeight) * (1 - startHeight) / cycleFrame / (1 - startHeight) * nowFrame + startHeight;
        }

        Vector2 height = rectTransform.sizeDelta;
        height.y = scale;
        rectTransform.sizeDelta = height;
    }
}
