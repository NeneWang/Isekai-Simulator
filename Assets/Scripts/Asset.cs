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

interface RealEstate
{
    void turnModifier(NaniDataManager naniDataManager);


}

class Carp : RealEstate, Asset
{
    public int price;
    public string name, description;

    public void turnModifier(NaniDataManager naniDataManager)
    {
        naniDataManager.p_happiness--;
        naniDataManager.p_health--;


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

class Farm : RealEstate, Asset
{
    public int price;
    public string name, description;

    public void turnModifier(NaniDataManager naniDataManager)
    {
        naniDataManager.p_happiness--;
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

class Tavern : RealEstate, Asset
{
    public int price;
    public string name, description;

    public void turnModifier(NaniDataManager naniDataManager)
    {
        naniDataManager.p_happiness++;
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

class Cabin : RealEstate, Asset
{
    public int price;
    public string name, description;

    public void turnModifier(NaniDataManager naniDataManager)
    {
        naniDataManager.p_health++;
        naniDataManager.p_happiness++;

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




