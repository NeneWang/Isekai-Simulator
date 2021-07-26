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
        int listLength = logList.Count;
        int randomIndex = Random.Range(0, listLength);

        return logList[randomIndex];

    }





}

public enum EnumRarity
{
    Normal = 1, Rare = 2, Miracle = 3
}

public class Log
{

    public string title;

    public EnumRarity enumRarity;

    public Effect onSuccessEffect = new Effect();
    public Effect onFailEffect = new Effect();

    public int rankRequired = 0;
    public LogType logType = new LogType();



    public Log(string titleIn, int enumRarityIn)
    {
        enumRarity = (EnumRarity)enumRarityIn;
        title = titleIn;

    }

}

public class Effect
{

    public int gold = 0, health = 0, happiness = 0, fame = 0;
}

public enum EnumCombatType
{
    notCombat = 0, fullVictoryChanceCombat = 1
}

public class LogType
{

}