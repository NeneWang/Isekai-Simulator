using System.Collections;
using System.Collections.Generic;
using Naninovel;
using UnityEngine;
using UnityEngine.UI;

public class LocationSprite : MonoBehaviour
{
    const int TENT = 0, FARM = 1, TAVERN = 2, CABIN = 3;

    public Sprite

            tentSprite,
            farmSprite,
            motelSprite,
            tavernSprite;

    public string p_livingmethod;

    public Image spriteRenderer;

    public void updateBase()
    {
        var variableManager = Engine.GetService<ICustomVariableManager>();
        var p_livingmethod = variableManager.GetVariableValue("p_livingmethod");

        // then the
        switch (int.Parse(p_livingmethod))
        {
            case TENT:
                spriteRenderer.sprite = tentSprite;
                break;
            case FARM:
                spriteRenderer.sprite = farmSprite;
                break;
            case TAVERN:
                spriteRenderer.sprite = tavernSprite;
                break;
            case CABIN:
                spriteRenderer.sprite = motelSprite;
                break;
        }
    }
}
