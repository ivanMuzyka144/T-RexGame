using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cable : MonoBehaviour
{

	public float speed, topSpeed;
	bool reached;
	Transform socketLine;

    void Awake()
    {
		socketLine = GameObject.Find("ScoketPosition").transform;
		reached = false;
    }


	void Update()
	{

		if (speed < topSpeed) {
			speed += RunManager.GetInstance().GetTempo() / 20 * Time.deltaTime;
		}

		if (transform.position.y >= socketLine.position.y)
		{
			reached = true;
		}

		if (!reached) { 
			transform.position += new Vector3(0, speed * Time.deltaTime, 0);
		}
	}
}
