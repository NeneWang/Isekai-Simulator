﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JobDescriptionChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public string tooltipDataRight;

    public string tooltipDataLeft;

    public SimpleTooltip simpleTooltip;
    public int jobId=1;

    string

            currentRank = "Diamond",
            nextRank = "Silver",
            jobTitle = "Aventurer";

    int

            workedAmount = 1,
            levelUpRequirement = 10, expectedPay=10;

    void Start()
    {
        updateToolTipData();
    }

    // Update is called once per frame
    void Update()
    {
    }


    void updateVariables(){
        // Here I will update the variables depending on the job number.
        currentRank = CustomFunctions.getCareerData(2,"d");
        expectedPay = int.Parse(CustomFunctions.getCareerData(2,"d"));
        // currentRank = CustomFunctions.getCareerData(2, "d");
        jobTitle = CustomFunctions.getCareerData(2,"a");
        

    }

    void updateToolTipData()
    {
        updateVariables();
        tooltipDataLeft =
            $"`Work as @{currentRank} Rank `{jobTitle}\n`You currently have worked @{workedAmount}`/{levelUpRequirement} times. \nExpected pay of ${expectedPay}";

        simpleTooltip.infoLeft=tooltipDataLeft;
    }
}
