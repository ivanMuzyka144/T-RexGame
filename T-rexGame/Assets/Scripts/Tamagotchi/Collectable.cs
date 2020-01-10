using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CType
{
    Meat,
    Water
}
public class Collectable : MonoBehaviour
{
    public CType typeOfItem;


    void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player")
		{
            if(typeOfItem == CType.Meat)
            {
                ItemBag.Instance.ChangeMeatAmount(true);
            }
            if (typeOfItem == CType.Water)
            {
                ItemBag.Instance.ChangeWaterAmount(true);
            }
            Destroy(gameObject);
		}
	}
    
}
