using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public string title;
    public string description;
    public int adquiredAmount;
    public int price;

}
public class Items
{
    public Item[] items;
}

public class ItemList
{


    public void initializeObjects()
    {

        string jsonItems = "{\"items\":[{    \"title\": \"potion\",    \"adquiredAmount\": 0,    \"price\": 10,    \"description\": \"hello world\"  },  {    \"title\": \"potion magic\",    \"adquiredAmount\": 1,    \"price\": 29,    \"description\": \"this is the potion you should have twice\"  } ]}";
        Items items = JsonUtility.FromJson<Items>(jsonItems);
        Debug.Log(items.items[0].title);

        // string jsonItem = "{ \"title\": \"potion\",\"description\": \"hello world\", \"adquiredAmount\": 2, \"price\": 22}";
        // Item item = (Item)JsonUtility.FromJson(jsonItem, typeof(Item));
        // Debug.Log((string) item.title);
        // Debug.Log(item.description);

    }
}
