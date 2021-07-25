using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Business
{
    string name;
    int startupCost = 500;
    int businessReputation;
    int maxReputation = 100;
    int unitEmployeeRevenue = 2;
    int businessRank;
    int baseEmployeeCost;

    int cashFlow
    {
        get => getCashflow();
    }

    List<Worker> employees = new List<Worker>();

    public int eemployeesCount
    {
        get => employees.Count;
    }

    public int getCashflow()
    {
        int totalCashflow = 0;
        // Add all the employees existing and then the cashflow
        foreach (Worker employee in employees)
        {
            totalCashflow += (int)(employee.multipliyer * unitEmployeeRevenue);
        }

        return totalCashflow;
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
    public string name;
    public double multipliyer;
    public double learningSpeed;
    public double maxMultiplier = 4;
    public int additionalEmployeeCost;

    public int seed;

    public Worker()
    {

    }

    public Worker(int seed)
    {
        // Seed: 1 -> Security guiy | 2 -> alchemist | 3 -> merchant
        randomGenerator myRandomGenerator = new randomGenerator();

        name = myRandomGenerator.generateName();

        float maxBaseMultiplier = 2;
        float minBaseMultiplier = 1;

        multipliyer = Random.Range(minBaseMultiplier, maxBaseMultiplier);
        learningSpeed = Random.Range(0.1f, 0.4f);
        additionalEmployeeCost = myRandomGenerator.randomAdditionalEmployeeCost();


    }

}