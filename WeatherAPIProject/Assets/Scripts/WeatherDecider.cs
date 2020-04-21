using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WeatherDecider : MonoBehaviour
{


    public GameObject[] clearObjects;
    public GameObject[] cloudyObjects;
    public GameObject[] rainyObjects;
    public void Setweather(string condition)
    {
        TurnOffAll();
        if (condition == "Clear")
        {
            foreach (GameObject go in clearObjects)
            {
                go.SetActive(true);
            }
        }
        else if (condition == "Clouds")
        {
            foreach (GameObject go in cloudyObjects)
            {
                go.SetActive(true);
            }
        }
        else if (condition == "Rain")
        {
            foreach (GameObject go in rainyObjects)
            {
                go.SetActive(true);
            }
        }
        else
        {
            foreach (GameObject go in clearObjects)
            {
                go.SetActive(true);
            }

        }
    }
    public void TurnOffAll()
    {
        //disables all weather objects
        clearObjects = GameObject.FindGameObjectsWithTag("Clear");
        foreach (GameObject go in clearObjects)
        {
            go.SetActive(false);
        }
        cloudyObjects = GameObject.FindGameObjectsWithTag("Cloudy");
        foreach (GameObject go in cloudyObjects)
        {
            go.SetActive(false);
        }
        rainyObjects = GameObject.FindGameObjectsWithTag("Rainy");
        foreach (GameObject go in rainyObjects)
        {
            go.SetActive(false);
        }
    }
}
