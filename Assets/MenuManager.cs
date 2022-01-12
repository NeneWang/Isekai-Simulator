using System.Collections;
using System.Collections.Generic;
using Naninovel;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public int lastmenu;

    public Button

            storeButton,
            JobButton,
            profileButton,
            entertainmentButton;

    public void updateMenu()
    {
        var variableManager = Engine.GetService<ICustomVariableManager>();
        var valueAsString = variableManager.GetVariableValue("lastmenu");

        if (valueAsString == null)
        {
            return;
        }
        lastmenu = (int.Parse(valueAsString));
        buttonEnable();
        switch (lastmenu)
        {
            case 1:
                // disable profile
                profileButton.interactable = false;
                break;
            case 2:
                // disable market
                storeButton.interactable = false;
                break;
            case 3:
                // Disable job menu
                JobButton.interactable = false;
                break;
        }
    }

    public void buttonEnable()
    {
        storeButton.interactable = true;
        profileButton.interactable = true;
        JobButton.interactable = true;
    }
}
