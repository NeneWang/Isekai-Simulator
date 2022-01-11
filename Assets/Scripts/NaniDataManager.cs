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
    public bool isLog;

    public int p_turn, p_age, p_health, p_fame, p_mana, p_happiness, p_money, p_monthlyCashFlow, p_livingmethod, securityCompany, alchemyCompany, travelMerchant;
    public int p_missionsCompleted, p_maxhealth, p_networth, p_stat_str, p_stat_vit, p_stat_dex, p_stat_int, p_stat_wis, p_stat_char;
    public string p_title, p_sex, friend_sl_1, friend_sl_2, friend_sl_3, lover_sl_1, actionLog;

    // Friend items
    public int rel_janna, rel_atlas, rel_mitia, rel_kisa, rel_legeon, rel_vandeus, rel_gerald, rel_merlin, rel_aiza, rel_misterv;
    string jsonItems;

    public Constants MY_CONSTANTS = new Constants();
    public RandomGenerator randomGenerator = new RandomGenerator();
    public RelationshipManager relationshipManager = new RelationshipManager();

    // TODO: SET THIS VARIABLES LATER   

    public Job merchantCareer, tradeCareer, farmerCareer, civilServantCareer, aventurerCareer, mercenaryCareer, soldierCareer;
    public int p_currentInjuries, p_merchantS = 0, p_tradeS = 0, p_farmerS = 0, p_civilServantS = 0, p_aventurerS = 0, p_mercenaryS = 0, p_soldierS = 0, flag_number = 0, lastmenu = 1;

    private string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
    public bool friend_slavailable_1, friend_slavailable_2, friend_slavailable_3, lover_slavailable_1;

    int countMonths
    {
        get => months.Length;
    }

    public int p_age_current
    {
        get => p_age + countYear;
    }

    public int countYear
    {
        get => (p_turn / countMonths);
    }

    public int absoluteYear
    {
        get => countYear + MY_CONSTANTS.startingYear;
    }

    public string currentMonthName
    {
        get => months[p_turn % countMonths];
    }

    public string absoluteDateMessage
    {

        get => currentMonthName + " " + (absoluteYear).ToString();
    }




    public void fetch()
    {

        var variableManager = Engine.GetService<ICustomVariableManager>();



        variableManager.TryGetVariableValue<int>("p_turn", out p_turn);
        variableManager.TryGetVariableValue<int>("p_age", out p_age);
        variableManager.TryGetVariableValue<string>("p_sex", out p_sex);
        variableManager.TryGetVariableValue<int>("p_health", out p_health);
        variableManager.TryGetVariableValue<int>("p_fame", out p_fame);
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

        variableManager.TryGetVariableValue<string>("actionLog", out actionLog);
        variableManager.TryGetVariableValue<bool>("isLog", out isLog);

        variableManager.TryGetVariableValue<bool>("lover_slavailable_1", out lover_slavailable_1);
        variableManager.TryGetVariableValue<bool>("friend_slavailable_1", out friend_slavailable_1);
        variableManager.TryGetVariableValue<bool>("friend_slavailable_2", out friend_slavailable_2);
        variableManager.TryGetVariableValue<bool>("friend_slavailable_3", out friend_slavailable_3);



        variableManager.TryGetVariableValue<int>("flag_number", out flag_number);
        variableManager.TryGetVariableValue<int>("lastmenu", out lastmenu);

        variableManager.TryGetVariableValue<int>("lastmenu", out lastmenu);

        variableManager.TryGetVariableValue<int>("rel_janna", out rel_janna);
        variableManager.TryGetVariableValue<int>("rel_atlas", out rel_atlas);
        variableManager.TryGetVariableValue<int>("rel_mitia", out rel_mitia);
        variableManager.TryGetVariableValue<int>("rel_kisa", out rel_kisa);
        variableManager.TryGetVariableValue<int>("rel_legeon", out rel_legeon);
        variableManager.TryGetVariableValue<int>("rel_vandeus", out rel_vandeus);
        variableManager.TryGetVariableValue<int>("rel_gerald", out rel_gerald);
        variableManager.TryGetVariableValue<int>("rel_merlin", out rel_merlin);
        variableManager.TryGetVariableValue<int>("rel_aiza", out rel_aiza);
        variableManager.TryGetVariableValue<int>("rel_misterv", out rel_misterv);

        setupRelationshipManger();
        postCareerSuccess();
        updateModifiers();
        EventManager eventManager = new EventManager(this);



    }

    public NaniDataManager()
    {
        initializeCareers();
        fetch();

    }

    public void deathConditions()
    {
        if (p_health <= 0)
        {
            PrintScriptAsync("You died...");
        }

        if (p_happiness <= 0)
        {
            PrintScriptAsync("You died out of sadness...");
        }

        if (p_money < 0)
        {
            PrintScriptAsync("Debt Collectors collected your head...");
        }

    }

    public void safeGuardDatavariables()
    {
        if (p_happiness > 100)
        {
            p_happiness = 100;
        }

        if (p_happiness < 0)
        {
            p_happiness = 0;
        }

        if (p_health > p_maxhealth)
        {
            p_health = p_maxhealth;
        }
        if (p_health < 0)
        {
            p_health = 0;
        }

    }

    // Updates stuff like 
    public void newDay()
    {
        applyEffects();

    }

    public void applyEffects()
    {
        int accumulativeCashflowModifier = p_monthlyCashFlow;
        accumulativeCashflowModifier += MY_CONSTANTS.securityCompany.cashflowB1 * securityCompany;
        accumulativeCashflowModifier += MY_CONSTANTS.alchemyCompany.cashflowB1 * alchemyCompany;
        accumulativeCashflowModifier += MY_CONSTANTS.travelMerchant.cashflowB1 * travelMerchant;


        p_health += accumulativeHealthModifier;
        p_happiness += accumulativeHappinessModifier;
        p_money += accumulativeCashflowModifier;

        // Business income

        string moneyMessage = accumulativeCashflowModifier > 0 ? $"Earned {p_monthlyCashFlow} coins" : null;
        string healthMessage = accumulativeHealthModifier > 0 ? $"Recovered {accumulativeHealthModifier} HP" : null;
        string happinessMessage = accumulativeHappinessModifier > 0 ? $"Gained {accumulativeHappinessModifier} Happiness" : null;

        Debug.Log("money incoming");
        Debug.Log(moneyMessage);

        if (moneyMessage != null) ToastScriptAsync("moneyMessage");
        if (healthMessage != null) ToastScriptAsync("healthMessage");
        if (happinessMessage != null) ToastScriptAsync("happinessMessage");

    }


    private async void PlayScriptAsync(string argument)
    {

        var text = argument;
        var script = Script.FromScriptText(null, text);
        var playlist = new ScriptPlaylist(script);
        await playlist.ExecuteAsync();
    }
    

    private async void PrintScriptAsync(string argument)
    {
        
        var text = $"@print \"{argument}\"";
        var script = Script.FromScriptText(null, text);
        var playlist = new ScriptPlaylist(script);
        await playlist.ExecuteAsync();
    }

     private async void ToastScriptAsync(string argument)
    {
        
        var text = $"@toast \"{argument}\"";
        var script = Script.FromScriptText(null, text);
        var playlist = new ScriptPlaylist(script);
        await playlist.ExecuteAsync();
    }


    // 10 friends
    public int getFriendModifier()
    {
        double happinessModifierToReturn = 0;
        happinessModifierToReturn += rel_janna > 0 ? 0.5 : 0;
        happinessModifierToReturn += rel_atlas > 0 ? 0.2 : 0;
        happinessModifierToReturn += rel_mitia > 0 ? 0.3 : 0;
        happinessModifierToReturn += rel_kisa > 0 ? 0.5 : 0;
        happinessModifierToReturn += rel_legeon > 0 ? 0.2 : 0;
        happinessModifierToReturn += rel_vandeus > 0 ? 0.2 : 0;
        happinessModifierToReturn += rel_gerald > 0 ? 0.2 : 0;
        happinessModifierToReturn += rel_merlin > 0 ? 0.2 : 0;
        happinessModifierToReturn += rel_aiza > 0 ? 0.2 : 0;
        happinessModifierToReturn += rel_misterv > 0 ? 0.2 : 0;

        return (int)Math.Floor(happinessModifierToReturn);
    }


    public void updateModifiers()
    {
        // Cashflow 
        RealEstate[] realEstates = { MY_CONSTANTS.carp, MY_CONSTANTS.farm, MY_CONSTANTS.tavern, MY_CONSTANTS.cabin };
        p_monthlyCashFlow = -realEstates[p_livingmethod].getPrice();
        // Debug.Log(p_monthlyCashFlow);
        // Happiness
        accumulativeHappinessModifier = realEstates[p_livingmethod].happinessModifier;
        accumulativeHappinessModifier += getFriendModifier();
        // Health
        accumulativeHealthModifier = realEstates[p_livingmethod].healthModifier;
    }

    public bool canPurchase(int price)
    {
        if (price <= p_money)
        {
            actionLog = "You purchased at " + price.ToString();

            PlayScriptAsync(actionLog);
            return true;
        }
        actionLog = "The price: " + price.ToString() + " is too expensive for you.";
        PlayScriptAsync(actionLog);
        return false;
    }


    public bool canPurchaseThenPurhcase(int price, string itemName = "")
    {
        if (price <= p_money)
        {


            actionLog = "You purchased " + itemName + " at " + price.ToString();
            isLog = true;
            p_money -= price;
            return true;
        }

        actionLog = "The price: " + price.ToString() + " is for " + itemName + " is too expensive for you.";
        // isLog = true;
        PlayScriptAsync(actionLog);
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
        updateModifiers();
        deathConditions();
        safeGuardDatavariables();

        var variableManager = Engine.GetService<ICustomVariableManager>();
        variableManager.TrySetVariableValue("p_turn", p_turn);
        variableManager.TrySetVariableValue("p_age", p_age);
        variableManager.TrySetVariableValue("p_sex", p_sex);
        variableManager.TrySetVariableValue("p_health", p_health);

        variableManager.TrySetVariableValue("p_fame", p_fame);
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

        variableManager.TrySetVariableValue("friend_sl_1", friend_sl_1);

        // Debug.Log("setting: " + friend_sl_2);
        variableManager.TrySetVariableValue("friend_sl_2", friend_sl_2);
        variableManager.TrySetVariableValue("friend_sl_3", friend_sl_3);
        variableManager.TrySetVariableValue("lover_sl_1", lover_sl_1);

        variableManager.TrySetVariableValue("actionLog", actionLog);

        variableManager.TrySetVariableValue("isLog", isLog);
        variableManager.TrySetVariableValue("lover_slavailable_1", lover_slavailable_1);
        variableManager.TrySetVariableValue("friend_slavailable_1", friend_slavailable_1);
        variableManager.TrySetVariableValue("friend_slavailable_2", friend_slavailable_2);
        variableManager.TrySetVariableValue("friend_slavailable_3", friend_slavailable_3);

        variableManager.TrySetVariableValue("flag_number", flag_number);
        variableManager.TrySetVariableValue("lastmenu", lastmenu);

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

            case "e":
                dataToReturn = jobIn.leftToRankUp.ToString();
                break;
            case "f":
                dataToReturn = jobIn.getJobIncome.ToString();
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

    public bool workAsAventurer()
    {
        // Calculate the risks of injuries and stuff depending of ecach character
        // TODO get the successfully completed stat later on

        // Increase the stats in the stuff, the work, like increment the stats as the aventurer depending on the index? the bigger the more reason to increase
        p_stat_str += aventurerCareer.jobLevel;
        p_stat_dex += aventurerCareer.jobLevel;
        p_health += aventurerCareer.jobLevel;
        p_stat_int += aventurerCareer.jobLevel;



        aventurerCareer.successfullyCompletedThisJob();
        p_money += aventurerCareer.getJobIncome;
        saveData();

        perphapsGettingHurtChances();

        // TODO: Implement random log logic
        double randomDouble = randomGenerator.getRandom1ToZero();
        // double NORMAL_RATE = 0.2, RARE_RATE = 0.05, MIRACLE_RATE = 0.01;
        double NORMAL_RATE = 0.3, RARE_RATE = 0.2, MIRACLE_RATE = 0.1;
        double TOTAL_RATE = NORMAL_RATE + RARE_RATE + MIRACLE_RATE;

        Debug.Log(randomDouble);
        isLog = false;

        if (randomDouble <= TOTAL_RATE)
        {

            if (randomDouble >= randomDouble + RARE_RATE && randomDouble < TOTAL_RATE)
            {
                actionLog = MY_CONSTANTS.aventurerLogs.getRandomLogBasedOnRarity(EnumRarity.Normal).title;
            }

            else if (randomDouble >= NORMAL_RATE && randomDouble < randomDouble + RARE_RATE)
            {
                actionLog = MY_CONSTANTS.aventurerLogs.getRandomLogBasedOnRarity(EnumRarity.Rare).title;
            }
            else
            {
                actionLog = MY_CONSTANTS.aventurerLogs.getRandomLogBasedOnRarity(EnumRarity.Miracle).title;
            }

            // isLog = true;
            PlayScriptAsync(actionLog);
            return true;
        }

        return false;

    }



    public bool workAsSoldier()
    {
        // Calculate the risks of injuries and stuff depending of ecach character
        // TODO get the successfully completed stat later on

        // Increase the stats in the stuff, the work, like increment the stats as the aventurer depending on the index? the bigger the more reason to increase
        p_stat_str += soldierCareer.jobLevel;
        p_stat_dex += soldierCareer.jobLevel;
        p_health += (int)(soldierCareer.jobLevel * 1.5);



        soldierCareer.successfullyCompletedThisJob();
        p_money += soldierCareer.getJobIncome;
        saveData();
        perphapsGettingHurtChances();

        return false;

    }

    public bool workAsMerchant()
    {
        p_stat_wis += merchantCareer.jobLevel;
        p_stat_char += merchantCareer.jobLevel;


        // Now get paid
        Debug.Log("Getting paid as merchant");
        p_money += merchantCareer.getJobIncome;

        merchantCareer.successfullyCompletedThisJob();
        // TODO REmove following
        saveData();

        return false;

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
        newDay();
        p_turn++;
    }

    public void healFull()
    {
        p_health = p_maxhealth;
        // Debug.Log("Healed");
    }


}


