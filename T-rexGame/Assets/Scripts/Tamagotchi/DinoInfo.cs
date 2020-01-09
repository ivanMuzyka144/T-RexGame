using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoInfo : MonoBehaviour
{
    public int food = 100;
    public int water = 100;
    public int happiness = 100;

    public DinoInfo Instance; 
    void Start()
    {
        Instance = this;
    }

    // Update is cal
   //led once per frame
    void Update()
    {
        
    }
}
