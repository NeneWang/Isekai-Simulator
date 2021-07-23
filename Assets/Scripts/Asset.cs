using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface Asset
{
    int getPrice();
    string getTitle();
    string getDescription();

}

// Items Assets are in other other script



class RealEstate : Asset
{
    public int price = 0;
    public string name = "carp", description = "Simple and free.";
    public int happinessModifier = 0, HealthModifier = 0;
    public void turnModifier(NaniDataManager naniDataManager)
    {


    }

    public int getPrice()
    {
        return price;
    }

    public string getTitle()
    {
        return name;

    }

    public string getDescription()
    {
        return description;
    }

}






