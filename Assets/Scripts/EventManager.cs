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
        if(naniDataManager.p_age_current >= 20){
            naniDataManager.friend_sl_1 = "Arthur!HU!MA!1!20!1!100";
        }

        if(naniDataManager.p_age_current >= 21){
            naniDataManager.friend_sl_2 = "Alice!HU!FE!1!20!1!100";
        }
        if(naniDataManager.p_age_current >= 22){
            naniDataManager.friend_sl_2 = "Marth!HU!MA!1!20!1!100";
        }
    }

}
