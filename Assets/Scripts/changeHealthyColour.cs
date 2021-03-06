using System.Collections;
using System.Collections.Generic;
using Naninovel;
using UnityEngine;
using UnityEngine.UI;

public class changeHealthyColour : MonoBehaviour
{
    // Target the heart colours
    // Then change the colours depending on the score. Which since it has a trigger effect it calls here.
    public Image rend;

    public string variableName;
    public string valueAsString;
    public bool changeColor=true;

    public void changeValue(int value)
    {
        changeColour (value);
    }

    public virtual void changeValue()
    {
        
        var variableManager = Engine.GetService<ICustomVariableManager>();
        valueAsString = variableManager.GetVariableValue(variableName);

        if (valueAsString == null)
        {
            return;
        }
        changeColour(int.Parse(valueAsString));
    }

    void changeColour(int value)
    {
        if(!changeColor){
            return;
        }
        if (value >= 75)
        {
            rend.color = Color.green;
        }
        else if (value >= 40)
        {
            rend.color = Color.yellow;
        }
        else
        {
            // value less than 40
            rend.color = Color.red;
        }
    }
}
