using Naninovel;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Naninovel.ExpressionFunctions]
// Overall data manager
public class NaniDataManager
{

    string jsonItems;

    public void initializeSampleItems()
    {

        string jsonItems = "{\"items\":[{ \"title\": \"potion\",\"description\": \"hello world\"}]}";
        var items = SimpleJSON.JSON.Parse(jsonItems);
        Debug.Log(items["items"][0]["title"].Value);

    }

    public void fetch()
    {

        var variableManager = Engine.GetService<ICustomVariableManager>();
        variableManager.TryGetVariableValue<string>("jsonItems", out jsonItems);

    }

    public void saveData(){

        var variableManager = Engine.GetService<ICustomVariableManager>();
        variableManager.TrySetVariableValue("jsonItems", jsonItems);
    }

}


