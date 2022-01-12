using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSlideBar : changeHealthyColour
{
    public Slider slider;

    public int maxValue = 100;

    public override void changeValue()
    {
        base.changeValue();
        if (valueAsString != null)
        {
            Debug.Log(base.valueAsString);
            changeSize((float) float.Parse(base.valueAsString));
        }
    }

    void changeSize(float value)
    {
        slider.value = (float) value / maxValue;
    }
}
