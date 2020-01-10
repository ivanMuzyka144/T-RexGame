using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemBag : MonoBehaviour
{
    public static ItemBag Instance { get; set; }
    int amountOfMeat = 3;
    int amountOfWater = 3;

    public Text textAmountOfMeat;
    public Text textAmountOfWater;
    private void Awake()
    {
        Instance = this;
        textAmountOfMeat.text = amountOfMeat+"";
        textAmountOfWater.text = amountOfWater + "";
    }

    public void ChangeMeatAmount(bool needToIncrease)
    {
        if (needToIncrease)
        {
            amountOfMeat++;
        }
        else
        {
            if (amountOfMeat > 0)
            {
                amountOfMeat--;
            }
        }
        textAmountOfMeat.text = amountOfMeat + "";
    }

    public void ChangeWaterAmount(bool needToIncrease)
    {
        if (needToIncrease)
        {
            amountOfWater++;
        }
        else
        {
            if (amountOfWater > 0)
            {
                amountOfWater--;
            }
        }
        textAmountOfWater.text = amountOfWater + "";
    }

    
}
