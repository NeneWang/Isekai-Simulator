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

        NaniDataManager datanani = new NaniDataManager();
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
        NaniDataManager dataNani = new NaniDataManager();
        dataNani.initializeSampleItems();
        return true;
    }

    public static bool testObtainedVariables()
    {

        NaniDataManager dataNani = new NaniDataManager();
        dataNani.fetch();
        dataNani.testObtainedVariables();

        
        // Debug how it would save it using formattable
        Debug.Log(dataNani.getFormatableNaniTest());

        return true;

    }



}

