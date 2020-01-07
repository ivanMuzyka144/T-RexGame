using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceMoving : MonoBehaviour
{
    public float velocity;
    void Update()
    {
        transform.position = transform.position + new Vector3(velocity * Time.deltaTime, 0, 0);
    }
}
