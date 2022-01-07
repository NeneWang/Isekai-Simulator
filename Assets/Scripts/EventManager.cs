using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager
{
    public NaniDataManager naniDataManager;

    public EventManager(NaniDataManager NaniDataManagerIn)
    {
        naniDataManager = NaniDataManagerIn;
        createEventsDependingOnYears();
    }

    public void createEventsDependingOnYears(){
        int currentAge = naniDataManager.p_age_current;
        Debug.Log(currentAge);
        
        if(currentAge >= 20){
            naniDataManager.friend_sl_1 = "Arthur!HU!MA!1!20!1!100";
            naniDataManager.friend_slavailable_1 = true;
        }   

        if(currentAge >= 21){
            naniDataManager.friend_sl_2 = "Alice!HU!FE!1!20!1!100";
            naniDataManager.friend_slavailable_2 = true;
        }
        if(currentAge >= 22){
            naniDataManager.lover_sl_1 = "Lucy!HU!FE!1!20!1!100";
            naniDataManager.lover_slavailable_1 = true;
        }
        if(currentAge >= 23){
            naniDataManager.friend_sl_3 = "Lucas!HU!MA!1!20!1!100";

            naniDataManager.friend_slavailable_3 = true;
        }

        // Debug.Log(naniDataManager.relationshipManager.friends[2].name);
        // Debug.Log(naniDataManager.relationshipManager.friends[1].name);
    }

}
