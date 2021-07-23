using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Asset
{
    int getPrice();
    string getTitle();
    string getDescription();

}

// Items Assets are in other other script



public class RealEstate : Asset
{
    public int price = 0;
    public string name = "Carp", description = "Simple and free.";
    public int happinessModifier = 0, healthModifier = 0;
    public void turnModifier(NaniDataManager naniDataManager)
    {
        naniDataManager.p_health += healthModifier;
        naniDataManager.p_happiness += happinessModifier;

    }

    public RealEstate()
    {

    }
    public RealEstate(string nameIn, string descriptionIn, int happinessModifierIn, int healthModifierIn)
    {
        name = nameIn;
        description = descriptionIn;
        happinessModifier = happinessModifierIn;
        healthModifier = healthModifierIn;
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






