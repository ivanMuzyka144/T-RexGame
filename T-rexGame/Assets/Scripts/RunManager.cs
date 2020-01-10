using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunManager : MonoBehaviour
{
	private static RunManager instance;

	[SerializeField]
	float speed, tempo, topSpeed;

	float speedTmp, tempoTmp;

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

	public void Pause()
	{
		speedTmp = speed;
		tempoTmp = tempo;
		speed = 0;
		tempo = 0;
	}

	public void Play()
	{
		speed = speedTmp;
		tempo = tempoTmp;
	}

	void Update()
	{
		if (speed < topSpeed) { }
			speed += tempo / 10 * Time.deltaTime;
		}
	}

