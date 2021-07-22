using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Job
{
    public string careerTitle;
    // public int jobLevel = 0;
    public List<JobRank> jobRankList = new List<JobRank>();
    public int careerSuccess = 0;
    public int successJobsForNextRank = 2;

    public int jobLevel
    {
        // Calculated by counting the requirement for next level
        get
        {
            //checks each on if it is above to the next??? depending on the successfully worked times required, 
            //if it is bigger then should call itself recursively until it finds one specific, then FUCK. just make it normal so its about the individual job instead
            int jobLevelToReturn = (int)careerSuccess / successJobsForNextRank;

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
        get => getCurrentJobRank.title;
    }

    public int getJobIncome{
        get =>  getCurrentJobRank.payment;
    }

    public void successfullyCompletedThisJob()
    {
        careerSuccess++;
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

