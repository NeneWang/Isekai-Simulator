using Naninovel;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Naninovel.ExpressionFunctions]
// Overall data manager
public class DataNani
{

    public void initializeSampleItems()
    {

        string jsonItems = "{\"items\":[{    \"title\": \"potion\",    \"adquiredAmount\": 0,    \"price\": 10,    \"description\": \"hello world\"  },  {    \"title\": \"potion magic\",    \"adquiredAmount\": 1,    \"price\": 29,    \"description\": \"this is the potion you should have twice\"  } ]}";
        Items items = JsonUtility.FromJson<Items>(jsonItems);
        Debug.Log(items.items[0].title);

    }
}