using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Business
{
    string name;
    int cashflow;
    int startupCost;
    int businessReputation;
    int unitEmployeeRevenue;
    string businessRank;

    List<Worker> employees = new List<Worker>();

    public int eemployeesCount
    {
        get => employees.Count;
    }
}
public class Worker
{
    string name;
    double multipliyer;
    double learningSpeed;
    double maxMultiplier;

}