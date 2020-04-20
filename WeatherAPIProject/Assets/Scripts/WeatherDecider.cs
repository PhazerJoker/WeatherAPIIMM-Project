using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WeatherDecider : MonoBehaviour
{
    public void Setweather(string condition)
    {
        TurnOffAll();
        if(condition == "Sunny")
        {
            GameObject[] sunnyObjects = GameObject.FindGameObjectsWithTag("Sunny");
            foreach(GameObject go in sunnyObjects)
            {
                go.SetActive(true);
            } 
        }
    }
    public void TurnOffAll()
    {
        //disables all weather objects
    GameObject[] sunnyObjects = GameObject.FindGameObjectsWithTag("Sunny");
            foreach(GameObject go in sunnyObjects)
            {
                go.SetActive(false);
            }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
