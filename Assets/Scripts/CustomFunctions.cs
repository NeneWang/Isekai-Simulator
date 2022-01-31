using System;
using System.Collections;
using System.Collections.Generic;
using Naninovel;
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
        datanani.newDay();
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

    public enum EnumSocial
    {
        Personal = 1,
        Lover = 2,
        Friend_1 = 3,
        Friend_2 = 4,
        Friend_3 = 5,
        all = 6
    }

    public static string getPersonData(int enumSocialIn, string typeIn)
    {
        string variableToReturn = "";
        NaniDataManager naniDataManager = new NaniDataManager();

        switch ((EnumSocial) enumSocialIn)
        {
            case (EnumSocial.Personal):
                variableToReturn =
                    naniDataManager
                        .getThisPersonData(naniDataManager
                            .relationshipManager
                            .player,
                        typeIn);
                break;
            case (EnumSocial.Lover):
                variableToReturn =
                    naniDataManager
                        .getThisPersonData(naniDataManager
                            .relationshipManager
                            .lover,
                        typeIn);
                break;
            case (EnumSocial.Friend_1):
                variableToReturn =
                    naniDataManager
                        .getThisPersonData(naniDataManager
                            .relationshipManager
                            .getFriendN(0),
                        typeIn);
                break;
            case (EnumSocial.Friend_2):
                variableToReturn =
                    naniDataManager
                        .getThisPersonData(naniDataManager
                            .relationshipManager
                            .getFriendN(1),
                        typeIn);
                break;
            case (EnumSocial.Friend_3):
                variableToReturn =
                    naniDataManager
                        .getThisPersonData(naniDataManager
                            .relationshipManager
                            .getFriendN(2),
                        typeIn);
                break;
            default:
                variableToReturn = "Error index out of bound enum Social In";
                break;
        }

        return variableToReturn;
    }

    public static bool visit(int enumSocialIn)
    {
        bool actionSuccess = false;
        NaniDataManager naniDataManager = new NaniDataManager();

        switch ((EnumSocial) enumSocialIn)
        {
            case (EnumSocial.Friend_1):
                break;
            default:
                break;
        }

        return actionSuccess;
    }

    public enum enumCareer
    {
        Soldier = 1,
        Aventurer = 2,
        Merchant = 3
    }

    // A more efficient way to work in a career, Returns false if there is a false return.
    public static bool workCareerAs(int enumCareerIn)
    {
        
        NaniDataManager datanani = new NaniDataManager();
        bool isLogReturned = false;
        switch ((enumCareer) enumCareerIn)
        {
            case enumCareer.Soldier:
                isLogReturned = datanani.workAsSoldier();
                break;
            case enumCareer.Aventurer:
                isLogReturned = datanani.workAsAventurer();
                break;
            case enumCareer.Merchant:
                isLogReturned = datanani.workAsMerchant();
                break;
        }

        datanani.increaseTurn();
        datanani.saveData();

        return isLogReturned;
    }

    public static string getCareerData(int enumCareerIn, string typeIn)
    {
        string variableToReturn = "";
        NaniDataManager naniDataManager = new NaniDataManager();

        switch (enumCareerIn)
        {
            case ((int) enumCareer.Soldier):
                variableToReturn =
                    naniDataManager
                        .getThisCareerData(naniDataManager.soldierCareer,
                        typeIn);
                break;
            case ((int) enumCareer.Aventurer):
                variableToReturn =
                    naniDataManager
                        .getThisCareerData(naniDataManager.aventurerCareer,
                        typeIn);
                break;
            case ((int) enumCareer.Merchant):
                variableToReturn =
                    naniDataManager
                        .getThisCareerData(naniDataManager.merchantCareer,
                        typeIn);
                break;
            default:
                variableToReturn = "ERROR CAREER NUM EXCEEDED";
                break;
        }
        return variableToReturn;
    }

    public static bool runEvent(int eventNumber){
        NaniDataManager naniDataManager = new NaniDataManager("soft");
        
        Log eventLog = naniDataManager.MY_CONSTANTS.aventurerLogs.logList[eventNumber];
        
        naniDataManager.runEvent(eventLog);
        return true;
    }

    public enum enumBusiness
    {
        securityCompany = 1,
        alchemyCompany = 2,
        travelMerchant = 3
    }

    public static bool purchaseBusiness(int enumBusinessIn)
    {
        NaniDataManager naniDataManager = new NaniDataManager();
        int businessCost = 0;
        switch (enumBusinessIn)
        {
            case ((int) enumBusiness.securityCompany):
                businessCost =
                    naniDataManager.MY_CONSTANTS.securityCompany.startupCost;
                if (
                    naniDataManager
                        .canPurchaseThenPurhcase(businessCost,
                        "a security company")
                )
                {
                    naniDataManager.securityCompany++;
                    Debug
                        .Log($"purchased sec company now you have: {naniDataManager.securityCompany} of them");
                }

                break;
            case ((int) enumBusiness.alchemyCompany):
                businessCost =
                    naniDataManager.MY_CONSTANTS.alchemyCompany.startupCost;
                if (
                    naniDataManager
                        .canPurchaseThenPurhcase(businessCost,
                        "an alchemy company")
                )
                {
                    naniDataManager.alchemyCompany++;
                }
                break;
            case ((int) enumBusiness.travelMerchant):
                businessCost =
                    naniDataManager.MY_CONSTANTS.travelMerchant.startupCost;
                if (
                    naniDataManager
                        .canPurchaseThenPurhcase(businessCost,
                        "a merchant cart")
                )
                {
                    naniDataManager.travelMerchant++;
                }
                break;
            default:
                Debug.LogError("ERROR BUSINESS NUM EXCEEDED");
                break;
        }

        // Given that the modifiers should change
        naniDataManager.saveData();

        return true;
    }

    public enum enumItems
    {
        healingKit = 1,
        potion = 2
    }

    public static bool purchaseItem(int enumItemsIn)
    {
        NaniDataManager naniDataManager = new NaniDataManager();
        int itemCost = 0;
        switch (enumItemsIn)
        {
            case ((int) enumItems.healingKit):
                itemCost = 100;
                if (
                    naniDataManager
                        .canPurchaseThenPurhcase(itemCost, "healing kit")
                )
                {
                    naniDataManager.healAmount(50);
                    naniDataManager.increaseTurn();
                }
                break;
            case ((int) enumItems.potion):
                itemCost = 500;
                if (
                    naniDataManager
                        .canPurchaseThenPurhcase(itemCost,
                        "instant health potion")
                )
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

        // Debug.Log(messageDate);
        return messageDate;
    }

    public static bool menuJob()
    {
        _ = printMenuChoices();
        _ = printMainStatus();
        PlayScriptAsync("@set lastmenu=3\n@back bg-guild\n\"What will you be doing this week?\" [skipInput]\n@choice \"Work\" gosub:.showJobMenu\n@choice \"Socialize\" gosub:.takeABreak");

        return true;
    }

    public static bool menuProfile()
    {
        PlayScriptAsync("@set lastmenu=1\n@showUI Profile");
        _ = printMenuChoices();
        _ = printMainStatus();

        return true;
    }

    public static bool menuMarket()
    {
        PlayScriptAsync("@set lastmenu=2\n@back bg-store\n@char merchant look:left pos:45,-40");
        PlayScriptAsync("\"How can I help you?\" [skipInput]\n@choice \"Purchase\" goto:.marketBuyMenu\n@choice \"Sell\" goto:.marketBuyMenu\"");
        _ = printMenuChoices();
        _ = printMainStatus();
        return true;
    }

    public static bool printMenuChoices()
    {
        PlayScriptAsync("@showUI TownShort");
        return true;
    }

    public static bool printMainStatus()
    {
        PlayScriptAsync("@showUI StatusBar");
        return true;
    }

    public static bool cleanUI()
    {
        PlayScriptAsync("@hideChars\n@hideUI StoreMenu\n@hideUI Profile if:lastmenu!=1\n@set p_animation=99\n@hideUI JobMenu\n@resetText\n");
        return true;
    }

    private static async void PlayScriptAsync(string argument)
    {
        var text = argument;
        var script = Script.FromScriptText(null, text);
        var playlist = new ScriptPlaylist(script);
        await playlist.ExecuteAsync();
    }
}
