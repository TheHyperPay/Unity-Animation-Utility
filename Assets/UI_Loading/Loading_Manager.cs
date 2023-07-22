using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading_Manager : MonoBehaviour
{
    public GameObject loading;

    private UI_Spin ui_Spin;

    int fps = 0;

    void Start()
    {
        ui_Spin = loading.GetComponent<UI_Spin>();
    }

    private void FixedUpdate()
    {
        ui_Spin.accelerationClockwiseSpin(loading, 60, fps);
        //ui_Spin.SpinToFewDegree(loading, 0f, 150f, 120, fps);

        fps++;
    }
}
