using Naninovel;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Naninovel.ExpressionFunctions]
// Overall data manager
public class NaniDataManager
{
    public int p_turn, p_age, p_health, p_mana, p_happiness, p_money, p_monthlyCashFlow;
    public int p_missionsCompleted, p_maxhealth, p_networth, p_stat_str, p_stat_vit, p_stat_dex, p_stat_int, p_stat_wis, p_stat_char;
    public string p_title, p_sex;

    string jsonItems;

    public Constants MY_CONSTANTS = new Constants();

    // TODO: SET THIS VARIABLES LATER

    public Job merchantCareer, tradeCareer, farmerCareer, civilServantCareer, aventurerCareer, mercenaryCareer, soldierCareer;
    public int p_currentInjuries, p_merchantS = 0, p_tradeS = 0, p_farmerS = 0, p_civilServantS = 0, p_aventurerS = 0, p_mercenaryS = 0, p_soldierS = 0;
    public NaniDataManager()
    {

        // Initialization of variables and stuff 
        // TODO: Remove this
        initializeCareers();
        fetch();

    }
    public void initializeSampleItems()
    {

        string jsonItems2 = "{\"items\":[{ \"title\": \"potion\",\"description\": \"hello world\"}]}";
        var items = SimpleJSON.JSON.Parse(jsonItems2);
        Debug.Log(items["items"][0]["title"].Value);

    }



    public void testObtainedVariables()
    {


        var items = SimpleJSON.JSON.Parse(jsonItems);
        Debug.Log(items[0][0]["title"].Value);
        Debug.Log(jsonItems);

    }

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



    }

    public void saveData()
    {

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
        // variableManager.TrySetVariableValue("p_mercenaryS", p_mercenaryS);
        variableManager.TrySetVariableValue("p_soldierS", p_soldierS);
        variableManager.TrySetVariableValue("p_currentInjuries", p_currentInjuries);



    }

    public string getJsonFormattableOf(string input)
    {
        input = input.Replace("-", "\"");
        input = input.Replace("!", "{");
        input = input.Replace("~", "}");
        input = "{0:[" + input + "]}";
        return input;
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

        merchantCareer.workedSuccessfully = p_merchantS;
        aventurerCareer.workedSuccessfully = p_aventurerS;
        soldierCareer.workedSuccessfully = p_soldierS;

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


        if (getTrueWithProbablity(.96))
        {
            aventurerCareer.successfullyCompletedThisJob();
            increaseTurn();
            saveData();
        }

        perphapsGettingHurtChances();

    }

    public void workAsMerchant()
    {
        // p_stat_wis += aventurerCareer.jobLevel;
        // p_stat_char += aventurerCareer.jobLevel;

        // Calculate the chances of failures and success SIMPLIFICATION
        // merchantCareer.successfullyCompletedThisJob();

        // Now get paid
        Debug.Log("Getting paid as merchant");
        p_money += 30;

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
        p_turn++;
    }








    // WORK


}


