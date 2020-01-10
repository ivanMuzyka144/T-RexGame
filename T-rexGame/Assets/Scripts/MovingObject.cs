using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
	void Update()
	{
		transform.position -= new Vector3(RunManager.GetInstance().GetSpeed() * Time.deltaTime,0,0);
	}

	void OnBecameInvisible()
	{
		Destroy(gameObject);
	}
}
