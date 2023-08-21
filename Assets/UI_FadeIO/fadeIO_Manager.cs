using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class fadeIO_Manager : MonoBehaviour
{
    public GameObject maskObject;
    public GameObject backgroundObject;

    private UI_Scale ui_Scale;
    private RectTransform maskTransform;

    private bool effectToggleSwitch = false;
    private int frame = 0;

    private void Start()
    {
        ui_Scale = maskObject.GetComponent<UI_Scale>();
        maskTransform = maskObject.GetComponent<RectTransform>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(!effectToggleSwitch)
                effectToggleSwitch = true;
            else
                effectToggleSwitch = false;

            frame = 0;
        }
    }

    private void FixedUpdate()
    {
        if(effectToggleSwitch) //extend
        {
            ui_Scale.scaleChangeWidthToEndWidth(maskTransform, 0f, 1300f, 90, frame);
            ui_Scale.scaleChangeHeightToEndHeight(maskTransform, 0f, 1300f, 90, frame++);
        }
        else //shrink
        {
            ui_Scale.scaleChangeWidthToEndWidth(maskTransform, 1300f, 0f, 90, frame);
            ui_Scale.scaleChangeHeightToEndHeight(maskTransform, 1300f, 0f, 90, frame++);
        }

    }
}
