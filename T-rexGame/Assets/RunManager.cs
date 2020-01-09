using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunManager : MonoBehaviour
{
	private static RunManager instance;

	[SerializeField]
	float speed, tempo;


	public static RunManager GetInstance()
	{
		return instance;
	}

	public float GetSpeed()
	{
		return speed;
	}

	private void Awake()
	{
		if (instance == null)
			instance = gameObject.GetComponent<RunManager>();
		else
			Destroy(gameObject);
	}

	void Update()
    {
		speed += tempo/10 *  Time.deltaTime;
    }
}
