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
    public int price;
    public string name, description;

    public void turnModifier()
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




