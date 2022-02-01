using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CashflowDescriptionChanger : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI cashFlowNumberLabel;
    public void updateCashFlowText(){
        cashFlowNumberLabel.text= CustomFunctions.getInformation(1);
    }
}
