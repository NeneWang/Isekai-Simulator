using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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