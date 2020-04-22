//Script for setting the speed for the Windmill
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindmillSpeed : MonoBehaviour
{
    //Variable creations
    public GameObject windmillFan;
    public float windSpeed;
    public float spin;
    public void setSpeed(float newWindSpeed)
    {
        //Taking the newWindSpeed float and giving it to the windSpeed float
        windSpeed = (newWindSpeed);
    }
    void Update()
    {
        //Every frame it turns the windmill fan model (windSpeed * 2 * Time passed) degrees per second
        spin = windSpeed * 50 * Time.deltaTime;
        windmillFan.transform.Rotate(spin, 0, 0);
    }
}

