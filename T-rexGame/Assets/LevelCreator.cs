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
	GameObject ptero;

	[SerializeField]
	Transform groundReference, groundEdge;

	[SerializeField]
	float groundStep;

	float frequency;

	Vector3 currentPosition;

	private float nextSpawn;

	void Start()
	{
		currentPosition = new Vector3(-8, groundReference.position.y, groundReference.position.z);

		for (int i =0; i<7; i++)
		{
			CreateGround(currentPosition);
			if (i > 3 && i % 2 == 0)
				if (Random.Range(0, 4) >= 2)
				{
					CreateObstacle(currentPosition);
				}
		}
		
		
    }

	void CreateGround(Vector3 position)
	{
		
		Instantiate(ground[Random.Range(0, ground.Length - 1)], position, groundReference.rotation);
		currentPosition.x += groundStep;

	}


	void CreateObstacle(Vector3 position)
	{
		Instantiate(cactuses[Random.Range(0, cactuses.Length - 1)], position + new Vector3(0, 0.1f), Quaternion.identity);
	}

	int lastObst = 0;

	void Update()
    {
		
		frequency = groundStep /RunManager.GetInstance().GetSpeed();
		if (Time.time >= nextSpawn)
		{
			nextSpawn = Time.time + frequency;
			CreateGround(groundEdge.position);
			if (Random.Range(0, lastObst) >= 1)
			{	
				CreateObstacle(groundEdge.position);
				lastObst = 0;
			}
			else
			{
				lastObst++;
			}
		}
		
	}
}
