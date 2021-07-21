using Naninovel;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Naninovel.ExpressionFunctions]


public static class CustomFunctions
{

    public enum careerEnum
    {
        Soldier = 1, Aventurer = 2, Merchant = 3
    }

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

    public static string getCareerData(int careerEnumIn, string typeIn)
    {


        string variableToReturn = "";

        NaniDataManager naniDataManager = new NaniDataManager();



        switch (careerEnumIn)
        {

            case ((int)careerEnum.Soldier):
                variableToReturn = naniDataManager.getThisCareerData(naniDataManager.soldierCareer, typeIn);
                break;

            case ((int)careerEnum.Aventurer):
                variableToReturn = naniDataManager.getThisCareerData(naniDataManager.soldierCareer, typeIn);
                break;

            case ((int)careerEnum.Merchant):
                variableToReturn = naniDataManager.getThisCareerData(naniDataManager.soldierCareer, typeIn);
                break;

            default:
                variableToReturn = "ERROR CAREER NUM EXCEEDED";
                break;

        }
        return variableToReturn;
    }





}

