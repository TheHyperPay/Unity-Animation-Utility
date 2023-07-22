using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Comment_Manager : MonoBehaviour
{
    public GameObject commentWindow;
    public Text commentText;

    private Image commentImage;
    private UI_Comment comment;
    private UI_Scale commentScale;
    private RectTransform iconTransform;

    int fps = 0;
    int fpsText = 0;
    bool isPrintAll = false;

    string cmtText = "귀하는 <color=#FF00FF><b>포켓몬 도감</b></color>을 훌륭하게 완성했습니다!\n이 위대한 공적을 기리며 <b>상장</b>을 수여합니다.";

    const int FPS_MAX = 5;
    const int FPP = 4;

    // Start is called before the first frame update
    void Start()
    {
        commentImage = commentWindow.GetComponent<Image>();
        iconTransform = commentWindow.GetComponent<RectTransform>();
        comment = commentWindow.GetComponent<UI_Comment>();
        commentScale= commentWindow.GetComponent<UI_Scale>();
    }

    private void FixedUpdate()
    {
        comment.fadeOutImage(commentImage, FPS_MAX, fps);
        comment.fadeOutText(commentText, FPS_MAX, fps);
        commentScale.scaleChangeYAxisToEndSize(iconTransform, 0.5f, 1f, FPS_MAX - 1, fps);
        commentScale.scaleChangeXAxisToEndSize(iconTransform, 0.95f, 1f, FPS_MAX - 1, fps);

        comment.printTextToUI(commentText, cmtText, fpsText, FPP, isPrintAll);
        //Debug.Log(fps);
        if (fps < FPS_MAX)
        {
            fps++;
        }
        else if (fps == FPS_MAX && fpsText < FPP * cmtText.Length) 
        {
            fpsText++;
        }

        if(fpsText>100)
        {
            //isPrintAll = true;
        }
    }    
}
