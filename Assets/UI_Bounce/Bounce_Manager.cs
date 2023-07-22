using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bounce_Manager : MonoBehaviour
{
    public GameObject icon;

    private RectTransform iconTransform;
    UI_Bounce ui_Bounce;

    private float[] b_peak = { 70f, 30f, 10f , 0f};
    private int[] b_fps = { 42, 25, 15, 80 };

    int count = 0;
    int fps = 0;

    void Start()
    {
        iconTransform = icon.GetComponent<RectTransform>();
        ui_Bounce = GetComponent<UI_Bounce>();
    }

    private void FixedUpdate()
    {
        iconTransform.anchoredPosition = new Vector2(0, ui_Bounce.valticalityUpMovement(-150f, b_peak[count], b_fps[count], fps));

        fps++;
        if (fps == b_fps[count])
        {
            if (count == 3)
            {
                count = 0;
            }
            else
            {
                count++;
            }
            fps=0;
        }
    }
}
 