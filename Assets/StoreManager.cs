using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    void screenActivityUpdater()
    {
        screenGameObjectItem.SetActive(screenItem);
        screenGameObjectBlacksmith.SetActive(screenBlacksmith);
        screenGameObjectProperties.SetActive(screenProperties);
        screenGameObjectBusiness.SetActive(screenBusiness);
        screenGameObjectBlackmarket.SetActive(screenBlackmarket);
    }
}
