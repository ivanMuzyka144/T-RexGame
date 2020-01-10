using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTimer : MonoBehaviour
{
    double time = 0;
    void Update()
    {
        time += float.Parse(Time.deltaTime.ToString("0.00"))*10;
        char[] rowScore=Math.Truncate(time).ToString().ToCharArray();//100
        Array.Reverse(rowScore);
        string reversedString = new string(rowScore);
        while (reversedString.Length != 5)
        {
            reversedString += "0";
        }
        char[] normalArray = reversedString.ToCharArray();
        Array.Reverse(normalArray);
        Debug.Log(new string(normalArray));
    }
}
