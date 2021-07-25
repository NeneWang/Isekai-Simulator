using Naninovel;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Naninovel.ExpressionFunctions]
// Overall data manager
public class NaniDataManager
{

    // Accumulative, not intnded to be added here
    public int accumulativeHappinessModifier, accumulativeHealthModifier;

    public int p_turn, p_age, p_health, p_mana, p_happiness, p_money, p_monthlyCashFlow, p_livingmethod, securityCompany, alchemyCompany, travelMerchant;
    public int p_missionsCompleted, p_maxhealth, p_networth, p_stat_str, p_stat_vit, p_stat_dex, p_stat_int, p_stat_wis, p_stat_char;
    public string p_title, p_sex, friend_sl_1, friend_sl_2, friend_sl_3, lover_sl_1;

    string jsonItems;

    public Constants MY_CONSTANTS = new Constants();
    public RelationshipManager relationshipManager = new RelationshipManager();

    // TODO: SET THIS VARIABLES LATER

    public Job merchantCareer, tradeCareer, farmerCareer, civilServantCareer, aventurerCareer, mercenaryCareer, soldierCareer;
    public int p_currentInjuries, p_merchantS = 0, p_tradeS = 0, p_farmerS = 0, p_civilServantS = 0, p_aventurerS = 0, p_mercenaryS = 0, p_soldierS = 0;

    public void fetch()
    {

        var variableManager = Engine.GetService<ICustomVariableManager>();



        variableManager.TryGetVariableValue<int>("p_turn", out p_turn);
        variableManager.TryGetVariableValue<int>("p_age", out p_age);
        variableManager.TryGetVariableValue<string>("p_sex", out p_sex);
        variableManager.TryGetVariableValue<int>("p_health", out p_health);
        variableManager.TryGetVariableValue<int>("p_mana", out p_mana);
        variableManager.TryGetVariableValue<int>("p_happiness", out p_happiness);
        variableManager.TryGetVariableValue<int>("p_money", out p_money);
        variableManager.TryGetVariableValue<int>("p_monthlyCashFlow", out p_monthlyCashFlow);
        variableManager.TryGetVariableValue<string>("p_title", out p_title);
        variableManager.TryGetVariableValue<int>("p_missionsCompleted", out p_missionsCompleted);
        variableManager.TryGetVariableValue<int>("p_maxhealth", out p_maxhealth);
        variableManager.TryGetVariableValue<int>("p_networth", out p_networth);
        variableManager.TryGetVariableValue<int>("p_stat_str", out p_stat_str);
        variableManager.TryGetVariableValue<int>("p_stat_vit", out p_stat_vit);
        variableManager.TryGetVariableValue<int>("p_stat_dex", out p_stat_dex);
        variableManager.TryGetVariableValue<int>("p_stat_int", out p_stat_int);
        variableManager.TryGetVariableValue<int>("p_stat_wis", out p_stat_wis);
        variableManager.TryGetVariableValue<int>("p_stat_char", out p_stat_char);


        variableManager.TryGetVariableValue<int>("p_merchantS", out p_merchantS);
        // variableManager.TryGetVariableValue<int>("p_tradeS", out p_tradeS);
        // variableManager.TryGetVariableValue<int>("p_farmerS", out p_farmerS);
        // variableManager.TryGetVariableValue<int>("p_civilServantS", out p_civilServantS);
        variableManager.TryGetVariableValue<int>("p_aventurerS", out p_aventurerS);
        // variableManager.TryGetVariableValue<int>("p_mercenaryS", out p_mercenaryS);
        variableManager.TryGetVariableValue<int>("p_soldierS", out p_soldierS);
        // variableManager.TryGetVariableValue<int>("p_currentInjuries", out p_currentInjuries);

        variableManager.TryGetVariableValue<int>("p_currentInjuries", out p_currentInjuries);

        variableManager.TryGetVariableValue<string>("friend_sl_1", out friend_sl_1);
        variableManager.TryGetVariableValue<string>("friend_sl_2", out friend_sl_2);
        variableManager.TryGetVariableValue<string>("friend_sl_3", out friend_sl_3);
        // lover_sl_1

        variableManager.TryGetVariableValue<string>("lover_sl_1", out lover_sl_1);

        variableManager.TryGetVariableValue<int>("p_livingmethod", out p_livingmethod);

        variableManager.TryGetVariableValue<int>("securityCompany", out securityCompany);
        variableManager.TryGetVariableValue<int>("alchemyCompany", out alchemyCompany);
        variableManager.TryGetVariableValue<int>("travelMerchant", out travelMerchant);

        setupRelationshipManger();
        postCareerSuccess();
        updateModifiers();



    }

    public NaniDataManager()
    {
        initializeCareers();
        fetch();

    }

    // Updates stuff like 
    public void updateStatistics()
    {
        applyEffects();

    }

    public void applyEffects()
    {
        p_health += accumulativeHealthModifier;
        p_happiness += accumulativeHappinessModifier;
        p_money += p_monthlyCashFlow;

        // Business income
        p_money += MY_CONSTANTS.securityCompany.cashflowB1 * securityCompany;
        p_money += MY_CONSTANTS.alchemyCompany.cashflowB1 * alchemyCompany;
        p_money += MY_CONSTANTS.travelMerchant.cashflowB1 * travelMerchant;


    }

    public void updateModifiers()
    {
        // Cashflow 
        RealEstate[] realEstates = { MY_CONSTANTS.carp, MY_CONSTANTS.farm, MY_CONSTANTS.tavern, MY_CONSTANTS.cabin };
        p_monthlyCashFlow -= realEstates[p_livingmethod].getPrice();

        // Happiness
        accumulativeHappinessModifier += realEstates[p_livingmethod].happinessModifier;

        // Health
        accumulativeHealthModifier += realEstates[p_livingmethod].happinessModifier;
    }

    public bool canPurchase(int price)
    {
        if (price <= p_money)
        {
            return true;
        }
        return false;
    }

    
    public bool canPurchaseThenPurhcase(int price)
    {
        if (price <= p_money)
        {
            p_money-=price;
            return true;
        }
        
        return false;
    }

    public void initializeSampleItems()
    {

        string jsonItems2 = "{\"items\":[{ \"title\": \"potion\",\"description\": \"hello world\"}]}";
        var items = SimpleJSON.JSON.Parse(jsonItems2);
        Debug.Log(items["items"][0]["title"].Value);

    }

    public void initializeSocial()
    {

    }



    public void testObtainedVariables()
    {


        var items = SimpleJSON.JSON.Parse(jsonItems);
        Debug.Log(items[0][0]["title"].Value);
        Debug.Log(jsonItems);

    }

    public void fetchCareerSuccess()
    {
        // ## TODO Complete JObs
        p_soldierS = soldierCareer.careerSuccess;
        p_merchantS = merchantCareer.careerSuccess;
        p_aventurerS = aventurerCareer.careerSuccess;

    }


    public void postCareerSuccess()
    {
        // ## TODO Complete JObs
        soldierCareer.careerSuccess = p_soldierS;
        merchantCareer.careerSuccess = p_merchantS;
        aventurerCareer.careerSuccess = p_aventurerS;

    }




    public void setupRelationshipManger()
    {
        relationshipManager.initializeFriendsWithString(new string[] { friend_sl_1, friend_sl_2, friend_sl_3 });
        relationshipManager.lover = relationshipManager.dataToPerson(lover_sl_1);
        // TODO: Add Personal and Love Interest

    }

    public void saveData()
    {

        fetchCareerSuccess();

        var variableManager = Engine.GetService<ICustomVariableManager>();
        variableManager.TrySetVariableValue("p_turn", p_turn);
        variableManager.TrySetVariableValue("p_age", p_age);
        variableManager.TrySetVariableValue("p_sex", p_sex);
        variableManager.TrySetVariableValue("p_health", p_health);
        variableManager.TrySetVariableValue("p_mana", p_mana);
        variableManager.TrySetVariableValue("p_happiness", p_happiness);
        variableManager.TrySetVariableValue("p_money", p_money);
        variableManager.TrySetVariableValue("p_monthlyCashFlow", p_monthlyCashFlow);
        variableManager.TrySetVariableValue("p_title", p_title);
        variableManager.TrySetVariableValue("p_missionsCompleted", p_missionsCompleted);
        variableManager.TrySetVariableValue("p_maxhealth", p_maxhealth);
        variableManager.TrySetVariableValue("p_networth", p_networth);
        variableManager.TrySetVariableValue("p_stat_str", p_stat_str);
        variableManager.TrySetVariableValue("p_stat_vit", p_stat_vit);
        variableManager.TrySetVariableValue("p_stat_dex", p_stat_dex);
        variableManager.TrySetVariableValue("p_stat_int", p_stat_int);

        // string modJsonItems = getNaniFormattableOf(jsonItems);
        // variableManager.TrySetVariableValue("jsonItems", modJsonItems);

        variableManager.TrySetVariableValue("p_merchantS", p_merchantS);
        // variableManager.TrySetVariableValue("p_tradeS", p_tradeS);
        // variableManager.TrySetVariableValue("p_farmerS", p_farmerS);
        // variableManager.TrySetVariableValue("p_civilServantS", p_civilServantS);



        variableManager.TrySetVariableValue("p_aventurerS", p_aventurerS);
        variableManager.TrySetVariableValue("p_soldierS", p_soldierS);
        variableManager.TrySetVariableValue("p_currentInjuries", p_currentInjuries);

        // TODO: Set the relationshipDataHerelater



    }

    public string getJsonFormattableOf(string input)
    {
        input = input.Replace("-", "\"");
        input = input.Replace("!", "{");
        input = input.Replace("~", "}");
        input = "{0:[" + input + "]}";
        return input;
    }

    public string getThisCareerData(Job jobIn, string typeIn)
    {
        string dataToReturn = "";
        typeIn = typeIn.ToLower();
        switch (typeIn)
        {
            case "a":
                dataToReturn = jobIn.careerTitle;
                break;

            case "b":
                dataToReturn = jobIn.careerSuccess.ToString();
                break;

            case "c":
                dataToReturn = jobIn.jobLevel.ToString();
                break;

            case "d":
                dataToReturn = jobIn.getJobRankName;
                break;

            default:
                dataToReturn = "typein Exceeded";
                break;

        }


        return dataToReturn;
    }

    public string getThisPersonData(Person targetPerson, string typeIn)
    {
        string dataToReturn = "";
        typeIn = typeIn.ToLower();
        switch (typeIn)
        {
            case "a":
                dataToReturn = targetPerson.name;
                break;

            case "b":
                dataToReturn = targetPerson.race.ToString();
                break;

            case "c":
                dataToReturn = targetPerson.gender.ToString();
                break;

            case "d":
                dataToReturn = targetPerson.socialClassType.ToString();
                break;

            case "e":
                dataToReturn = targetPerson.age.ToString();
                break;
            case "f":
                dataToReturn = targetPerson.level.ToString();
                break;
            case "g":
                dataToReturn = targetPerson.relationship.ToString();
                break;
            case "h":
                dataToReturn = targetPerson.socialClassType.ToString();
                break;

            default:
                dataToReturn = "Social typein Exceeded";
                break;

        }


        return dataToReturn;
    }

    public string getFormatableNaniTest()
    {
        return getNaniFormattableOf(jsonItems);
    }

    public string getNaniFormattableOf(string input)
    {

        input = input.Replace("]}", "");
        input = input.Replace("{0:[", "");
        input = input.Replace("\"", "-");
        input = input.Replace("{", "!");
        input = input.Replace("}", "~");

        return input;
    }


    public void initializeCareers()
    {

        aventurerCareer = MY_CONSTANTS.getJobFromName("Aventurer");
        soldierCareer = MY_CONSTANTS.getJobFromName("Soldier");
        merchantCareer = MY_CONSTANTS.getJobFromName("Merchant");

        // tradeCareer = MY_CONSTANTS.getJobFromName("Trades");
        // farmerCareer = MY_CONSTANTS.getJobFromName("Farmer");
        // civilServantCareer = MY_CONSTANTS.getJobFromName("Civil Servant");
        // mercenaryCareer = MY_CONSTANTS.getJobFromName("Mercenary");


        aventurerCareer.careerSuccess = p_aventurerS;
        soldierCareer.careerSuccess = p_soldierS;
        merchantCareer.careerSuccess = p_merchantS;

        // tradeCareer.workedSuccessfully = p_tradeS;
        // farmerCareer.workedSuccessfully = p_farmerS;
        // civilServantCareer.workedSuccessfully = p_civilServantS;
        // mercenaryCareer.workedSuccessfully = p_mercenaryS;


    }

    public void workAsAventurer()
    {
        // Calculate the risks of injuries and stuff depending of ecach character
        // TODO get the successfully completed stat later on

        // Increase the stats in the stuff, the work, like increment the stats as the aventurer depending on the index? the bigger the more reason to increase
        p_stat_str += aventurerCareer.jobLevel;
        p_stat_dex += aventurerCareer.jobLevel;
        p_health += aventurerCareer.jobLevel;
        p_stat_int += aventurerCareer.jobLevel;


        if (getTrueWithProbablity(.98))
        {
            aventurerCareer.successfullyCompletedThisJob();
            p_money += aventurerCareer.getJobIncome;
            increaseTurn();
            saveData();
        }

        perphapsGettingHurtChances();

    }



    public void workAsSoldier()
    {
        // Calculate the risks of injuries and stuff depending of ecach character
        // TODO get the successfully completed stat later on

        // Increase the stats in the stuff, the work, like increment the stats as the aventurer depending on the index? the bigger the more reason to increase
        p_stat_str += soldierCareer.jobLevel;
        p_stat_dex += soldierCareer.jobLevel;
        p_health += (int)(soldierCareer.jobLevel * 1.5);


        if (getTrueWithProbablity(.98))
        {
            soldierCareer.successfullyCompletedThisJob();
            p_money += soldierCareer.getJobIncome;
            increaseTurn();
            saveData();
        }

        perphapsGettingHurtChances();

    }

    public void workAsMerchant()
    {
        p_stat_wis += merchantCareer.jobLevel;
        p_stat_char += merchantCareer.jobLevel;

        // Calculate the chances of failures and success SIMPLIFICATION
        // merchantCareer.successfullyCompletedThisJob();

        // Now get paid
        Debug.Log("Getting paid as merchant");
        p_money += merchantCareer.getJobIncome;

        merchantCareer.successfullyCompletedThisJob();

        increaseTurn();
        // TODO REmove following
        saveData();

    }

    public void perphapsGettingHurtChances()
    {
        if (getTrueWithProbablity(.1))
        {
            // Chances of getting hurt a little

            if (getTrueWithProbablity(.1))
            {
                // Chances of getting hurt letally
                p_health -= 50;
                if (p_currentInjuries >= 1)
                {
                    // TODO kill the player
                }

            }
            else
            {

                p_health -= 10;
            }
        }
        saveData();
    }

    public bool getTrueWithProbablity(double probability)
    {
        System.Random random = new System.Random();
        return random.NextDouble() < probability;
    }


    public void increaseTurn()
    {
        updateStatistics();
        p_turn++;
    }

    public void healFull(){
        p_health=p_maxhealth;
        Debug.Log("Healed");
    }


}


