using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCreator : MonoBehaviour
{
	[SerializeField]
	GameObject[] ground;

	[SerializeField]
	GameObject[] cactuses;

	[SerializeField]
	GameObject[] supply;


	[SerializeField]
	GameObject ptero;

	[SerializeField]
	Transform groundReference, groundEdge;

	[SerializeField]
	float groundStep;

	float frequency;

	Vector3 currentPosition;
	Vector3[] verticals;

	private float nextSpawn;

	void Start()
	{
		verticals = new Vector3[3];
		verticals[0] = new Vector3(0, 0.5f);
		verticals[1] = new Vector3(0, 1.5f);
		verticals[2] = new Vector3(0, 2f);


		currentPosition = new Vector3(-8, groundReference.position.y, groundReference.position.z);

		for (int i =0; i<6; i++)
		{
			CreateGround(currentPosition);
		}
		
		
    }

	void CreateGround(Vector3 position)
	{
		
		Instantiate(ground[Random.Range(0, ground.Length)], position, groundReference.rotation);
		currentPosition.x += groundStep;

	}


	void CreateObstacle(Vector3 position)
	{
		Instantiate(cactuses[Random.Range(0, cactuses.Length)], position + new Vector3(0, 0.1f), Quaternion.identity);
	}

	void CreateSuply(Vector3 position)
	{
		Instantiate(supply[Random.Range(0, supply.Length)], position, Quaternion.identity);
	}

	int lastObst = 0;
	int lastSup = 0;
	int minHeight = 0;

	void Update()
    {
		minHeight = 0;

		frequency = groundStep /RunManager.GetInstance().GetSpeed();
		if (Time.time >= nextSpawn)
		{
			nextSpawn = Time.time + frequency;
			CreateGround(groundEdge.position);
			if (Random.Range(0, lastObst) >= 1)
			{	
				CreateObstacle(groundEdge.position);
				lastObst = 0;
				minHeight = 1;
			}
			else
			{
				lastObst++;
			}
			if(Random.Range(0, lastSup) >= 4)
			{
				Instantiate(supply[Random.Range(0, supply.Length)], groundEdge.position+verticals[Random.Range(minHeight,verticals.Length)], Quaternion.identity);
				lastSup = 0;
			}
			else
			{
				lastSup++;
			}

		}
		
	}
}
