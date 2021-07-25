using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Business
{
    string name;
    // TODO: Make this a getter instead
    int cashflow;
    int startupCost=500;
    int businessReputation;
    int maxReputation= 100;
    int unitEmployeeRevenue = 1;
    int businessRank;
    int baseEmployeeCost;

    List<Worker> employees = new List<Worker>();

    public int eemployeesCount
    {
        get => employees.Count;
    }

    public Business(string nameIn, int startupCostIn, int businessReputationIn, int unitEmployeeRevenueIn, int baseEmployeeCostIn)
    {
        name = nameIn;
        startupCost = startupCostIn;
        businessReputation = businessReputationIn;
        unitEmployeeRevenue = unitEmployeeRevenueIn;
        baseEmployeeCost = baseEmployeeCostIn;

    }

    // TODO: Create a business Rank Title based on the business rank



}
public class Worker
{
    string name;
    double multipliyer;
    double learningSpeed;
    double maxMultiplier;
    int employeeCost;

}