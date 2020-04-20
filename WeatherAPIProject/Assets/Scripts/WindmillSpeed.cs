//Script for setting the speed for the Windmill
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindmillSpeed : MonoBehaviour
{
    public Wind wind;
    public GameObject windMill;

    // Update is called once per frame
    void Update()
    {
       
        if (wind.speed > 1 && wind.speed <= 5)
        {
            windMill.transform.Rotate(10 * Time.deltaTime, 0, 0);
        }else if (wind.speed > 5 && wind.speed <= 20)
        {
            windMill.transform.Rotate (50*Time.deltaTime,0,0);
        }else if (wind.speed > 20 && wind.speed <= 50)
        {
            windMill.transform.Rotate (100*Time.deltaTime,0,0);
        }
        else if (wind.speed > 50)
        {
            windMill.transform.Rotate (200*Time.deltaTime,0,0);
        }
        else
        {
            windMill.transform.Rotate (0,0,0);
        }
    }
}
