using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCreator : MonoBehaviour
{
	[SerializeField]
	GameObject[] groud;

	[SerializeField]
	GameObject[] cactuses;

	[SerializeField]
	GameObject ptero;

	[SerializeField]
	Transform groundReference , movingObject;

	[SerializeField]
	float groundStep;


	void Awake()
    {
		CreateGround();
    }

	void CreateGround()
	{
		Vector3 position = new Vector3(-8, groundReference.position.y, groundReference.position.z);
		for (int i = 0; i<50; i++)
		{

			Instantiate(groud[Random.Range(0, groud.Length - 1)], position, groundReference.rotation, movingObject);

			if (i > 6 && i%2==0)
				CreateObstacle(position);

			position.x += groundStep;
		}

	}


	void CreateObstacle(Vector3 position)
	{
		if (Random.Range(0, 4) >= 2)
		{
			Instantiate(cactuses[Random.Range(0, cactuses.Length - 1)], position, Quaternion.identity, movingObject);
		}
	}

    void Update()
    {
        
    }
}
