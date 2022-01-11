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
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void toggleScreen(int screenInteger)
    {
        switch (screenInteger)
        {
            case 1:
                screenItem = !screenItem;
                break;
            case 2:
                screenBlacksmith = !screenBlacksmith;
                break;
            case 3:
                screenProperties = !screenProperties;
                break;
            case 4:
                screenBusiness = !screenBusiness;
                break;
            case 5:
                screenBlackmarket = !screenBlackmarket;
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
