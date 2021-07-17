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

        string jsonItems2 = "{\"items\":[{ \"title\": \"potion\",\"description\": \"hello world\"}]}";
        var items = SimpleJSON.JSON.Parse(jsonItems2);
        Debug.Log(items["items"][0]["title"].Value);

    }

    public void testObtainedVariables()
    {


        var items = SimpleJSON.JSON.Parse(jsonItems);
        Debug.Log(items[0][0]["title"].Value);
        Debug.Log(jsonItems);

    }

    public void fetch()
    {

        var variableManager = Engine.GetService<ICustomVariableManager>();
        variableManager.TryGetVariableValue<string>("jsonItems", out jsonItems);
        jsonItems = getJsonFormattableOf(jsonItems);

    }

    public void saveData()
    {

        var variableManager = Engine.GetService<ICustomVariableManager>();
        variableManager.TrySetVariableValue("jsonItems", jsonItems);
    }

    public string getJsonFormattableOf(string input)
    {
        input = input.Replace("-", "\"");
        input = input.Replace("!", "{");
        input = input.Replace("~", "}");
        input = "{0:[" + input + "]}";
        return input;
    }

    public string getFormatableNaniTest(){
        return getNaniFormattableOf(jsonItems);
    }

    public string getNaniFormattableOf(string input)
    {

        input = input.Replace("]}", "");
        input = input.Replace("{0:[", "");
        input = input.Replace("\"", "-");
        input = input.Replace("{", "!");
        input = input.Replace("}", "~");

        return input;
    }

}


