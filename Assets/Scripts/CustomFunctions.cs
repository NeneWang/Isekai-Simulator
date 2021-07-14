using Naninovel;
using System;
using System.Collections;
using System.Collections.Generic;
[Naninovel.ExpressionFunctions]
public static class CustomFunctions
{

    public static bool addMoney(int addMoney)
    {

        DataNani datanani = new DataNani();

        datanani.p_money += addMoney;
        datanani.p_networth += addMoney;

        datanani.saveData();
        return true;

    }

    public static bool increaseTurn()
    {

        DataNani datanani = new DataNani();
        datanani.increaseTurn();
        datanani.saveData();
        return true;

    }


    public class Constants
    {
        public List<Job> jobList = new List<Job>();

        public Constants()
        {
            // First we are on need to create the jobranks and then add those to the thing 
            JobRank temporalJobRank;

            // Farmer
            List<JobRank> farmerJobRanks = new List<JobRank>();
            farmerJobRanks.Add(new JobRank(10, "Serf"));
            farmerJobRanks.Add(new JobRank(15, "Herder"));
            farmerJobRanks.Add(new JobRank(20, "Senior"));
            farmerJobRanks.Add(new JobRank(30, "Administrator"));

            List<JobRank> aventurerJobRanks = new List<JobRank>();
            aventurerJobRanks.Add(new JobRank(15, "Porcelain"));
            aventurerJobRanks.Add(new JobRank(20, "Obsidian"));
            aventurerJobRanks.Add(new JobRank(30, "Steel"));
            aventurerJobRanks.Add(new JobRank(40, "Emerald"));
            aventurerJobRanks.Add(new JobRank(60, "Ruby"));
            aventurerJobRanks.Add(new JobRank(85, "Bronze"));
            aventurerJobRanks.Add(new JobRank(120, "Silver"));
            aventurerJobRanks.Add(new JobRank(200, "Gold"));

            List<JobRank> CivilServantJobRanks = new List<JobRank>();
            CivilServantJobRanks.Add(new JobRank(20, "Bookbinder"));
            CivilServantJobRanks.Add(new JobRank(25, "Scholar"));
            CivilServantJobRanks.Add(new JobRank(30, "Officer"));
            CivilServantJobRanks.Add(new JobRank(35, "Assistant Attache"));

            temporalJobRank = new JobRank(50, "Attache");
            temporalJobRank.setRequiresNobility();
            CivilServantJobRanks.Add(temporalJobRank);
            CivilServantJobRanks.Add(new JobRank(85, "Secretary"));
            CivilServantJobRanks.Add(new JobRank(80, "Minister"));
            CivilServantJobRanks.Add(new JobRank(100, "Counsellor"));



            // Add all ranks into the jobLists
            jobList.Add(new Job("Farmer", farmerJobRanks));
            jobList.Add(new Job("Aventurer", aventurerJobRanks));

            // jobList.Add(new Job("farmer", new int[] {10, 15, 20, 30}, new string[] {"Farmer", "Herder", "Senior Farmer", "Farm Administrator"}));
            // jobList.Add(new Job("aventurer", new int[] {15, 20, 30, 40, 50, 65, 80, 100, 200}, new string[] {"Porcerlain", "Herder", "Senior Farmer", "Farm Administrator"}));
        }
    }



    public class JobRank
    {
        public int payment;
        public string title;
        public int turnsForNext = 120;
        public bool requiresNobility = false;

        public void setRequiresNobility()
        {
            this.requiresNobility = true;
        }
        public JobRank(int paymentIn, string titleIn)
        {
            payment = paymentIn;
            title = titleIn;

        }


    }
    public class Job
    {
        public string careerTitle;
        public int jobLevel = 0;
        public List<JobRank> jobRankList = new List<JobRank>();

        public Job(string careerTitleIn, List<JobRank> jobRankListIn)
        {
            jobRankList = jobRankListIn;
            careerTitle = careerTitleIn;

        }

        public JobRank getCurrentJobRank
        {
            get => jobRankList[jobLevel];
        }
        public string getJobRankName
        {
            get => jobRankList[jobLevel].title;
        }


    }



    //Returns the total monney, but also adds the networth on the backgroun
    public class DataNani
    {
        public int p_turn, p_age, p_health, p_mana, p_happiness, p_money, p_weeklyCashFlow;
        public int p_missionsCompleted, p_maxhealth, p_networth, p_stat_str, p_stat_vit, p_stat_dex, p_stat_int;
        public string p_title, p_sex;





        public DataNani()
        {
            fetchData();
        }

        public void increaseTurn()
        {
            p_turn++;
        }
        public void fetchData()
        {
            var variableManager = Engine.GetService<ICustomVariableManager>();
            variableManager.TryGetVariableValue<int>("p_turn", out p_turn);
            variableManager.TryGetVariableValue<int>("p_age", out p_age);
            variableManager.TryGetVariableValue<string>("p_sex", out p_sex);
            variableManager.TryGetVariableValue<int>("p_health", out p_health);
            variableManager.TryGetVariableValue<int>("p_mana", out p_mana);
            variableManager.TryGetVariableValue<int>("p_happiness", out p_happiness);
            variableManager.TryGetVariableValue<int>("p_money", out p_money);
            variableManager.TryGetVariableValue<int>("p_weeklyCashFlow", out p_weeklyCashFlow);
            variableManager.TryGetVariableValue<string>("p_title", out p_title);
            variableManager.TryGetVariableValue<int>("p_missionsCompleted", out p_missionsCompleted);
            variableManager.TryGetVariableValue<int>("p_maxhealth", out p_maxhealth);
            variableManager.TryGetVariableValue<int>("p_networth", out p_networth);
            variableManager.TryGetVariableValue<int>("p_stat_str", out p_stat_str);
            variableManager.TryGetVariableValue<int>("p_stat_vit", out p_stat_vit);
            variableManager.TryGetVariableValue<int>("p_stat_dex", out p_stat_dex);
            variableManager.TryGetVariableValue<int>("p_stat_int", out p_stat_int);
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
            variableManager.TrySetVariableValue("p_weeklyCashFlow", p_weeklyCashFlow);
            variableManager.TrySetVariableValue("p_title", p_title);
            variableManager.TrySetVariableValue("p_missionsCompleted", p_missionsCompleted);
            variableManager.TrySetVariableValue("p_maxhealth", p_maxhealth);
            variableManager.TrySetVariableValue("p_networth", p_networth);
            variableManager.TrySetVariableValue("p_stat_str", p_stat_str);
            variableManager.TrySetVariableValue("p_stat_vit", p_stat_vit);
            variableManager.TrySetVariableValue("p_stat_dex", p_stat_dex);
            variableManager.TrySetVariableValue("p_stat_int", p_stat_int);
        }




    }

}

