using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoInfo : MonoBehaviour
{
    public int food = 100;
    public int water = 100;
    public int happiness = 100;

    public float timer = 2.0f;

    public DinoInfo Instance; 
    void Start()
    {
        Instance = this;
    }

    public void Decrease()
    {
        food -= 10;
        water -= 10;
        happiness -= 10;
    }
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            Debug.Log("Decrease "+ food);
            Decrease();
            timer = 2.5f;
        }
    }
}
