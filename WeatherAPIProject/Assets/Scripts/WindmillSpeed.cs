//Script for setting the speed for the Windmill
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindmillSpeed : MonoBehaviour
{
    public GameObject windmillFan;
    public void setSpeed(int windSpeed)
    {
        
        //Turns the windmill wheel model windSpeed degrees per second
                windmillFan.transform.Rotate(windSpeed * Time.deltaTime, 0, 0);
    }
    
    

}

