using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateDate : MonoBehaviour
{
    public TextMeshProUGUI textMesh;

    public void updateDate()
    {
        NaniDataManager naniDataManager = new NaniDataManager();

        string messageDate = naniDataManager.absoluteDateMessage;
        textMesh.text = messageDate;
    }
}
