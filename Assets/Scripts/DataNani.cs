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
        string jsonItem = "{    \"title\": \"potion\",    \"adquiredAmount\": 0,    \"price\": 10,    \"description\": \"hello world\"  }";
        Item item = (Item)JsonUtility.FromJson(jsonItem, typeof(Item));
        Debug.Log((string)item.title);
        Debug.Log(item.description);

        string jsonItems = "{\"items\":[{    \"title\": \"potion\",    \"adquiredAmount\": 0,    \"price\": 10,    \"description\": \"hello world\"  }, {    \"title\": \"potion\",    \"adquiredAmount\": 0,    \"price\": 10,    \"description\": \"hello world\"  }]}";
        Items myItems = JsonUtility.FromJson<Items>(jsonItems);
        Debug.Log(myItems.items[0].title);

    }
}