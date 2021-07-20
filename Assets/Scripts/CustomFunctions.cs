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

        datanani.p_money += addMoney;
        datanani.p_networth += addMoney;

        datanani.saveData();
        return true;

    }

    public static bool increaseTurn()
    {

        NaniDataManager datanani = new NaniDataManager();
        datanani.increaseTurn();
        datanani.saveData();
        return true;

    }

    public static bool workAsMerchant()
    {
        NaniDataManager datanani = new NaniDataManager();

        Debug.Log("Working as Merchant");
        datanani.workAsMerchant();
        datanani.saveData();

        return true;
    }

    public static bool workAsAventurer()
    {
        NaniDataManager datanani = new NaniDataManager();
        datanani.workAsAventurer();
        datanani.saveData();

        return true;
    }


    public static bool workAsSoldier()
    {
        NaniDataManager datanani = new NaniDataManager();
        datanani.workAsSoldier();
        datanani.saveData();

        return true;
    }
    public static bool initializeItems()
    {
        Debug.Log("Initializing!");
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

