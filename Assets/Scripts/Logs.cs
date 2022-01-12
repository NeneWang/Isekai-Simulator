using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogsList
{
    public string logListName = "";
    public List<Log> logList = new List<Log>();

    public LogsList(string logListNameIn)
    {
        logListName = logListNameIn;
    }

    public Log getRandomLog()
    {
        return getRandom(logList);
    }

    public Log getRandomLogBasedOnRarity(EnumRarity enumRarityIn)
    {

        return getRandom(getLogListBasedOnRarity(enumRarityIn));

    }

    List<Log> getLogListBasedOnRarity(EnumRarity enumRarityIn)
    {

        return logList.FindAll(log => log.enumRarity == enumRarityIn);
    }

    Log getRandom(List<Log> LogListIn)
    {
        int listLength = LogListIn.Count;
        int randomIndex = Random.Range(0, listLength);

        return LogListIn[randomIndex];
    }





}

public enum EnumRarity
{
    Normal = 1, Rare = 2, Miracle = 3
}

public class Log
{

    public string title;
    public string description;
    public string choiceScript;
    public string choicesDescription;

    public EnumRarity enumRarity;


    public int rankRequired = 0;
    public LogType logType = new LogType();



    public Log(string titleIn, int enumRarityIn, string descriptionInIn="", string choiceScriptIn="", string choicesDescriptionIn="")
    {
        enumRarity = (EnumRarity)enumRarityIn;
        title = titleIn;
        description = descriptionInIn;
        choiceScript = choiceScriptIn;
        choicesDescription = choicesDescriptionIn;

    }

}