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

    public static bool workAsMerchant()
    {
        DataNani datanani = new DataNani();
        datanani.workAsMerchant();
        datanani.saveData();

        return true;
    }

    public static bool workAsAventurer()
    {
        DataNani datanani = new DataNani();
        datanani.workAsAventurer();
        datanani.saveData();

        return true;
    }


    public class Constants
    {
        public List<Job> jobList = new List<Job>();

        public Constants()
        {
            createJobs();
        }

        public void createJobs()
        {
            List<JobRank> farmerJobRanks = new List<JobRank>();
            farmerJobRanks.Add(new JobRank(10, "Serf"));
            farmerJobRanks.Add(new JobRank(15, "Herder"));
            farmerJobRanks.Add(new JobRank(20, "Senior"));
            farmerJobRanks.Add(new JobRank(30, "Administrator"));

            List<JobRank> aventurerJobRanks = new List<JobRank>();
            aventurerJobRanks.Add(new JobRank(10, "Porcelain"));
            aventurerJobRanks.Add(new JobRank(18, "Obsidian"));
            aventurerJobRanks.Add(new JobRank(24, "Steel"));
            aventurerJobRanks.Add(new JobRank(35, "Emerald"));
            aventurerJobRanks.Add(new JobRank(55, "Ruby"));
            aventurerJobRanks.Add(new JobRank(85, "Bronze"));
            aventurerJobRanks.Add(new JobRank(120, "Silver"));
            aventurerJobRanks.Add(new JobRank(200, "Gold"));
            aventurerJobRanks.Add(new JobRank(300, "Platinum"));

            List<JobRank> CivilServantJobRanks = new List<JobRank>();
            CivilServantJobRanks.Add(new JobRank(20, "Bookbinder"));
            CivilServantJobRanks.Add(new JobRank(25, "Scholar"));
            CivilServantJobRanks.Add(new JobRank(30, "Officer"));
            CivilServantJobRanks.Add(new JobRank(40, "Assistant Attache"));
            CivilServantJobRanks.Add(new JobRank(50, "Attache"));
            CivilServantJobRanks.Add(new JobRank(85, "Secretary"));
            CivilServantJobRanks.Add(new JobRank(100, "Minister"));
            CivilServantJobRanks.Add(new JobRank(120, "Counsellor"));

            List<JobRank> tradesmanJobRanks = new List<JobRank>();
            tradesmanJobRanks.Add(new JobRank(10, "Carpenter Apprentice"));
            tradesmanJobRanks.Add(new JobRank(20, "Carpenter"));
            tradesmanJobRanks.Add(new JobRank(35, "Master Carpenter"));
            tradesmanJobRanks.Add(new JobRank(55, "Mason"));
            tradesmanJobRanks.Add(new JobRank(75, "Engineer"));
            tradesmanJobRanks.Add(new JobRank(90, "Master Engineer"));

            List<JobRank> mercenaryJobRanks = new List<JobRank>();
            mercenaryJobRanks.Add(new JobRank(17, "Enlistee"));
            mercenaryJobRanks.Add(new JobRank(22, "Private"));
            mercenaryJobRanks.Add(new JobRank(32, "Lance Corporal"));
            mercenaryJobRanks.Add(new JobRank(42, "Corporal"));
            mercenaryJobRanks.Add(new JobRank(62, "Sargeant"));
            mercenaryJobRanks.Add(new JobRank(87, "Lieutenant"));
            mercenaryJobRanks.Add(new JobRank(122, "Captain"));
            mercenaryJobRanks.Add(new JobRank(185, "Major"));
            mercenaryJobRanks.Add(new JobRank(240, "Colonel"));

            List<JobRank> merchantJobRanks = new List<JobRank>();
            merchantJobRanks.Add(new JobRank(5, "Peddler"));
            merchantJobRanks.Add(new JobRank(8, "Dealer"));
            merchantJobRanks.Add(new JobRank(15, "Merchant Apprentice"));
            merchantJobRanks.Add(new JobRank(30, "Merchant"));
            merchantJobRanks.Add(new JobRank(50, "Broker"));
            merchantJobRanks.Add(new JobRank(80, "Entrepreneur"));
            merchantJobRanks.Add(new JobRank(120, "Tycoon"));

            List<JobRank> soldierJobRanks = new List<JobRank>();
            soldierJobRanks.Add(new JobRank(10, "Enlistee"));
            soldierJobRanks.Add(new JobRank(15, "Private"));
            soldierJobRanks.Add(new JobRank(25, "Lance Corporal"));
            soldierJobRanks.Add(new JobRank(35, "Corporal"));
            soldierJobRanks.Add(new JobRank(45, "Sargeant"));
            soldierJobRanks.Add(new JobRank(65, "Lieutenant"));
            soldierJobRanks.Add(new JobRank(90, "Captain"));
            soldierJobRanks.Add(new JobRank(125, "Major"));
            soldierJobRanks.Add(new JobRank(190, "Colonel"));
            soldierJobRanks.Add(new JobRank(260, "General"));

            jobList.Add(new Job("Farmer", farmerJobRanks));
            jobList.Add(new Job("Aventurer", aventurerJobRanks));
            jobList.Add(new Job("Civil Servant", CivilServantJobRanks));
            getJobFromName("Civil Servant").setSpecificToNobilityRequired(new int[] { 4, 5, 6, 7 });
            jobList.Add(new Job("Trades", tradesmanJobRanks));
            jobList.Add(new Job("Mercenary", mercenaryJobRanks));
            jobList.Add(new Job("Merchant", merchantJobRanks));
            jobList.Add(new Job("Soldier", soldierJobRanks));
            getJobFromName("Soldier").setSpecificToNobilityRequired(new int[] { 4, 5, 6, 7, 8, 9 });



        }

        public Job getJobFromName(string jobName)
        {
            return jobList.Find(delegate (Job jk)
            {
                return jk.getJobRankName == jobName;
            });
        }
    }

    public class ItemList
    {
        public string itemJS = @"{'potion':{'AmountAdquired':0,'Price':10,'Description':'hello world'},'potion magic':{'AmountAdquired':1,'Price':29,'Description':'this is the potion you should have twice'}}";


    }

    public class JobRank
    {
        public int payment;
        public string title;
        public int successJobsForNextRank = 120;
        public bool requiresNobility = false;

        public JobRank(int paymentIn, string titleIn)
        {
            payment = paymentIn;
            title = titleIn;

        }
        public void setRequiresNobility()
        {
            this.requiresNobility = true;
        }


    }
    public class Job
    {
        public string careerTitle;
        // public int jobLevel = 0;
        public List<JobRank> jobRankList = new List<JobRank>();
        public int workedSuccessfully = 0;
        public int successJobsForNextRank = 80;

        public int jobLevel
        {
            // Calculated by counting the requirement for next level
            get
            {
                //checks each on if it is above to the next??? depending on the successfully worked times required, 
                //if it is bigger then should call itself recursively until it finds one specific, then FUCK. just make it normal so its about the individual job instead
                int jobLevelToReturn = (int)workedSuccessfully / successJobsForNextRank;

                return jobLevelToReturn > careerTitlesCount ? careerTitlesCount : jobLevelToReturn;
            }
        }

        public int careerTitlesCount
        {
            get => jobRankList.Count;
        }
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

        public void successfullyCompletedThisJob()
        {
            workedSuccessfully++;
        }

        public void setSpecificToNobilityRequired(int[] indexes)
        {
            int rankSize = jobRankList.Count;
            foreach (int index in indexes)
            {
                if (!(index > rankSize))
                {
                    jobRankList[index].setRequiresNobility();

                }

            }
        }


    }



    public class DataNani
    {
        public int p_turn, p_age, p_health, p_mana, p_happiness, p_money, p_weeklyCashFlow;
        public int p_missionsCompleted, p_maxhealth, p_networth, p_stat_str, p_stat_vit, p_stat_dex, p_stat_int, p_stat_wis, p_stat_char;
        public string p_title, p_sex;
        public Constants MY_CONSTANTS = new Constants();

        // TODO: SET THIS VARIABLES LATER

        public Job merchantCareer, tradeCareer, farmerCareer, civilServantCareer, aventurerCareer, mercenaryCareer, soldierCareer;
        public int p_currentInjuries, p_merchantS, p_tradeS, p_farmerS, p_civilServantS, p_aventurerS, p_mercenaryS, p_soldierS;



        // The question being should I have 6 of them or upgrade one by one? it kind of makes easier for my eyes just to do 6, the others kind of requires tweeking



        public DataNani()
        {
            fetchData();
            initializeCareers();
        }

        public void initializeCareers()
        {
            merchantCareer = MY_CONSTANTS.getJobFromName("Merchant");
            tradeCareer = MY_CONSTANTS.getJobFromName("Trades");
            farmerCareer = MY_CONSTANTS.getJobFromName("Farmer");
            civilServantCareer = MY_CONSTANTS.getJobFromName("Civil Servant");
            aventurerCareer = MY_CONSTANTS.getJobFromName("Aventurer");
            mercenaryCareer = MY_CONSTANTS.getJobFromName("Mercenary");
            soldierCareer = MY_CONSTANTS.getJobFromName("Soldier");

            merchantCareer.workedSuccessfully = p_merchantS;
            tradeCareer.workedSuccessfully = p_tradeS;
            farmerCareer.workedSuccessfully = p_farmerS;
            civilServantCareer.workedSuccessfully = p_civilServantS;
            aventurerCareer.workedSuccessfully = p_aventurerS;
            mercenaryCareer.workedSuccessfully = p_mercenaryS;
            soldierCareer.workedSuccessfully = p_soldierS;

        }

        // TODO: is to complete the other works, but first attempt just with two jobs
        public void workAsMerchant()
        {
            p_stat_wis += aventurerCareer.jobLevel;
            p_stat_char += aventurerCareer.jobLevel;

            // Calculate the chances of failures and success
            merchantCareer.successfullyCompletedThisJob();


            increaseTurn();
            saveData();

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
            Random random = new Random();
            return random.NextDouble() < probability;
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
            variableManager.TryGetVariableValue<int>("p_stat_wis", out p_stat_wis);
            variableManager.TryGetVariableValue<int>("p_stat_char", out p_stat_char);

            variableManager.TryGetVariableValue<int>("p_merchantS", out p_merchantS);
            variableManager.TryGetVariableValue<int>("p_tradeS", out p_tradeS);
            variableManager.TryGetVariableValue<int>("p_farmerS", out p_farmerS);
            variableManager.TryGetVariableValue<int>("p_civilServantS", out p_civilServantS);
            variableManager.TryGetVariableValue<int>("p_aventurerS", out p_aventurerS);
            variableManager.TryGetVariableValue<int>("p_mercenaryS", out p_mercenaryS);
            variableManager.TryGetVariableValue<int>("p_soldierS", out p_soldierS);
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
            variableManager.TrySetVariableValue("p_weeklyCashFlow", p_weeklyCashFlow);
            variableManager.TrySetVariableValue("p_title", p_title);
            variableManager.TrySetVariableValue("p_missionsCompleted", p_missionsCompleted);
            variableManager.TrySetVariableValue("p_maxhealth", p_maxhealth);
            variableManager.TrySetVariableValue("p_networth", p_networth);
            variableManager.TrySetVariableValue("p_stat_str", p_stat_str);
            variableManager.TrySetVariableValue("p_stat_vit", p_stat_vit);
            variableManager.TrySetVariableValue("p_stat_dex", p_stat_dex);
            variableManager.TrySetVariableValue("p_stat_int", p_stat_int);

            variableManager.TrySetVariableValue("p_merchantS", p_merchantS);
            variableManager.TrySetVariableValue("p_tradeS", p_tradeS);
            variableManager.TrySetVariableValue("p_farmerS", p_farmerS);
            variableManager.TrySetVariableValue("p_civilServantS", p_civilServantS);
            variableManager.TrySetVariableValue("p_aventurerS", p_aventurerS);
            variableManager.TrySetVariableValue("p_mercenaryS", p_mercenaryS);
            variableManager.TrySetVariableValue("p_soldierS", p_soldierS);
            variableManager.TrySetVariableValue("p_currentInjuries", p_currentInjuries);
        }




    }

}

