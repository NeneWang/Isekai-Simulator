using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Business
{
    string name;
    int cashflow;
    int startupCost;
    int businessReputation;
    string businessRank;

    List<Worker> employees = new List<Worker>();

    public int eemployeesCount
    {
        get => employees.Count;
    }
}
public class Worker
{

}