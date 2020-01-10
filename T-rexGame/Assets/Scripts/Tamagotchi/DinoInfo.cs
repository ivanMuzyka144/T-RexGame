using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DinoInfo : MonoBehaviour
{
    public int meat = 100;
    public int water = 100;

    public float timer = 0.5f;

    public Slider meatSlider;
    public Slider waterSlider;

    public static DinoInfo Instance { get; set; } 
    void Start()
    {
        Instance = this;
    }

    public void Decrease()
    {
        meat -= 5;
        water -= 5;

        meatSlider.value = meat;
        waterSlider.value = water;
    }
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            Decrease();
            timer = 0.5f;
        }
    }
}
