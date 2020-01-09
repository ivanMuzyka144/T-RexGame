using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
	[SerializeField]
	CType type;

	enum CType
	{
		Meat,
		Watter
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		Debug.Log("Contacted!");
		if (col.gameObject.tag == "Player")
		{
			Destroy(gameObject);
		}
	}
    
}
