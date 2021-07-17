using Naninovel;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Naninovel.ExpressionFunctions]


public static class CustomFunctions
{

    public static bool addMoney(int addMoney)
    {

        DataNani datanani = new DataNani();
        return true;

    }

    public static bool increaseTurn()
    {

        return true;

    }

    public static bool workAsMerchant()
    {

        return true;
    }

    public static bool workAsAventurer()
    {
        return true;
    }

    public static bool initializeItems()
    {
        Debug.Log("Initializing");
        ItemList itemList = new ItemList();
        itemList.initializeObjects();
        return true;
    }



}

