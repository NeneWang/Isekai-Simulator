using Naninovel;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Naninovel.ExpressionFunctions]


public static class CustomFunctions
{



    public static bool loadNextTurn()
    {

        // TODO: Adds one to the personal turn, 
        NaniDataManager datanani = new NaniDataManager();
        datanani.p_turn++;
        // Reduce money given the livinghoods you should set up the modifiers in addition to the life and what not
        // Reduce because of the other effects
        datanani.updateStatistics();
        datanani.saveData();

        return true;
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

    public static string getPersonData(int enumSocialIn, string typeIn)
    {

        string variableToReturn = "";
        NaniDataManager naniDataManager = new NaniDataManager();

        switch (enumSocialIn)
        {
            case ((int)enumSocial.Personal):
                variableToReturn = naniDataManager.getThisPersonData(naniDataManager.relationshipManager.player, typeIn);
                break;
            case ((int)enumSocial.Lover):
                variableToReturn = naniDataManager.getThisPersonData(naniDataManager.relationshipManager.lover, typeIn);
                break;
            case ((int)enumSocial.Friend_1):
                variableToReturn = naniDataManager.getThisPersonData(naniDataManager.relationshipManager.getFriendN(0), typeIn);
                break;
            case ((int)enumSocial.Friend_2):
                variableToReturn = naniDataManager.getThisPersonData(naniDataManager.relationshipManager.getFriendN(1), typeIn);
                break;
            case ((int)enumSocial.Friend_3):
                variableToReturn = naniDataManager.getThisPersonData(naniDataManager.relationshipManager.getFriendN(2), typeIn);
                break;
            default:
                variableToReturn = "Error index out of bound enum Social In";
                break;
        }

        return variableToReturn;

    }
    public enum enumCareer
    {
        Soldier = 1, Aventurer = 2, Merchant = 3
    }

    public enum enumSocial
    {
        Personal = 1, Lover = 2, Friend_1 = 3, Friend_2 = 4, Friend_3 = 5
    }

    public static string getCareerData(int enumCareerIn, string typeIn)
    {
        string variableToReturn = "";
        NaniDataManager naniDataManager = new NaniDataManager();

        switch (enumCareerIn)
        {

            case ((int)enumCareer.Soldier):
                variableToReturn = naniDataManager.getThisCareerData(naniDataManager.soldierCareer, typeIn);
                break;

            case ((int)enumCareer.Aventurer):
                variableToReturn = naniDataManager.getThisCareerData(naniDataManager.aventurerCareer, typeIn);
                break;

            case ((int)enumCareer.Merchant):
                variableToReturn = naniDataManager.getThisCareerData(naniDataManager.merchantCareer, typeIn);
                break;

            default:
                variableToReturn = "ERROR CAREER NUM EXCEEDED";
                break;

        }
        return variableToReturn;
    }

    public enum enumBusiness
    {
        securityCompany = 1, alchemyCompany = 2, travelMerchant = 3
    }

    public static bool purchaseBusiness(int enumBusinessIn)
    {
        NaniDataManager naniDataManager = new NaniDataManager();
        int businessCost = 0;
        switch (enumBusinessIn)
        {
            case ((int)enumBusiness.securityCompany):
                businessCost = naniDataManager.MY_CONSTANTS.securityCompany.startupCost;
                if (naniDataManager.canPurchaseThenPurhcase(businessCost))
                {
                    naniDataManager.securityCompany++;
                }

                break;
            case ((int)enumBusiness.alchemyCompany):

                businessCost = naniDataManager.MY_CONSTANTS.alchemyCompany.startupCost;
                if (naniDataManager.canPurchaseThenPurhcase(businessCost))
                {
                    naniDataManager.alchemyCompany++;
                }
                break;

            case ((int)enumBusiness.travelMerchant):
                businessCost = naniDataManager.MY_CONSTANTS.travelMerchant.startupCost;
                if (naniDataManager.canPurchaseThenPurhcase(businessCost))
                {
                    naniDataManager.travelMerchant++;
                }
                break;
            default:
                Debug.LogError("ERROR BUSINESS NUM EXCEEDED");
                break;
        }
        naniDataManager.saveData();

        return true;


    }


    public enum enumItems
    {
        healingKit = 1, potion = 2,
    }

    public static bool purchaseItem(int enumItemsIn)
    {
        NaniDataManager naniDataManager = new NaniDataManager();
        int itemCost = 0;
        switch (enumItemsIn)
        {
            case ((int)enumItems.healingKit):
                itemCost = 100;
                if (naniDataManager.canPurchaseThenPurhcase(itemCost))
                {

                    naniDataManager.healFull();
                    naniDataManager.increaseTurn();
                }
                break;
            case ((int)enumItems.potion):
                itemCost = 500;
                if (naniDataManager.canPurchaseThenPurhcase(itemCost))
                {

                    naniDataManager.healFull();
                }
                break;

        }
        naniDataManager.saveData();

        return true;
    }

    public static string getAbsoluteDate()
    {
        NaniDataManager naniDataManager = new NaniDataManager();
        


        string messageDate = naniDataManager.absoluteDateMessage;

        return messageDate;

    }





}

