using System.Collections;
using System.Collections.Generic;
using Naninovel;
using UnityEngine;
using UnityEngine.UI;

public class StoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public bool

            screenItem = true,
            screenBlacksmith = false,
            screenProperties = false,
            screenBusiness = false,
            screenBlackmarket = false;

    public GameObject

            screenGameObjectItem,
            screenGameObjectBlacksmith,
            screenGameObjectProperties,
            screenGameObjectBusiness,
            screenGameObjectBlackmarket;

    public GameObject

            textBlacksmith,
            textProperties,
            textBusiness,
            textBlackMarket;

    void Start()
    {
        toggleScreen(1);
    }

    public void deactiveScreens()
    {
        screenItem = false;
        screenBlacksmith = false;
        screenProperties = false;
        screenBusiness = false;
        screenBlackmarket = false;
    }

    public void toggleScreen(int screenInteger)
    {
        var variableManager = Engine.GetService<ICustomVariableManager>();
        var rel_aiza = variableManager.GetVariableValue("rel_aiza");
        var rel_fareg = variableManager.GetVariableValue("rel_fareg");
        var rel_misterv = variableManager.GetVariableValue("rel_misterv");

        deactiveScreens();
        switch (screenInteger)
        {
            case 1:
                screenItem = true;
                break;
            case 2:
                screenBlacksmith = true;
                break;
            case 3:
                screenProperties = true;
                break;
            case 4:
                screenBusiness = true;
                break;
            case 5:
                screenBlackmarket = true;
                break;
        }

        if (!((int.Parse(rel_aiza) > 0)))
        {
            screenProperties = false;
            textProperties.SetActive(false);
        }
        if (!((int.Parse(rel_fareg) > 0)))
        {
            screenBlacksmith = false;
            textBlacksmith.SetActive(false);
        }
        if (!((int.Parse(rel_misterv) > 0)))
        {
            screenBlackmarket = false;
            textBlackMarket.SetActive(false);
        }

        screenActivityUpdater();
    }

    void screenActivityUpdater()
    {
        screenGameObjectItem.SetActive (screenItem);
        screenGameObjectBlacksmith.SetActive (screenBlacksmith);
        screenGameObjectProperties.SetActive (screenProperties);
        screenGameObjectBusiness.SetActive (screenBusiness);
        screenGameObjectBlackmarket.SetActive (screenBlackmarket);
    }
}
