using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Items
{
    public List<Item> items = new List<Item>();

    public void addItem(Item newItem)
    {
        items.Add(newItem);
    }
}
public class Item
{
    public string title;
    public string description;
    public int adquiredAmount;
    public int price;

    public void buyThisItem()
    {
        adquiredAmount++;
    }

}
