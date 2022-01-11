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

    void Start()
    {
        screenActivityUpdater();
    }
    
    public void deactiveScreens(){
        screenItem = false;
        screenBlacksmith = false;
        screenProperties = false;
        screenBusiness = false;
        screenBlackmarket = false;
    }
    public void toggleScreen(int screenInteger)
    {
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
