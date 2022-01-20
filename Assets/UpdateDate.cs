using System.Collections;
using System.Collections.Generic;
using Naninovel;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpdateDate : MonoBehaviour
{
    public TextMeshProUGUI textMesh;

    public void updateDate()
    {
        var variableManager = Engine.GetService<ICustomVariableManager>();
        var valueAsString = variableManager.GetVariableValue("p_turn");

        if (valueAsString == null || valueAsString == "1")
        {
            return;
        }
        // Debug.Log($"The Data var is {valueAsString}");

        NaniDataManager naniDataManager = new NaniDataManager();
        string messageDate = naniDataManager.absoluteDateMessage;
        textMesh.text = messageDate;
    }
}
