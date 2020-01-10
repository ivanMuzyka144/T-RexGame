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
                int currentAmountOfMeat= DinoInfo.Instance.meat;
                if (currentAmountOfMeat + 25 < 100)
                {
                    DinoInfo.Instance.meat += 25;
                }
                else
                {
                    DinoInfo.Instance.meat = 100;
                }
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
                int currentAmountOfWater = DinoInfo.Instance.water;
                if (currentAmountOfWater + 25 < 100)
                {
                    DinoInfo.Instance.water += 25;
                }
                else
                {
                    DinoInfo.Instance.water = 100;
                }
            }
        }
        textAmountOfWater.text = amountOfWater + "";
    }

    
}
