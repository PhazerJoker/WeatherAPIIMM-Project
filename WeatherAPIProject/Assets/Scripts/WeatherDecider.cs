using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WeatherDecider : MonoBehaviour
{

    //Declaring the game objects into a list 
    public GameObject[] clearObjects;
    public GameObject[] cloudyObjects;
    public GameObject[] rainyObjects;
    //Setweather is getting a string variable from the  WeatherHandler Script
    public void Setweather(string condition)
    {
        //Calling the class to Disable all weather objects
        TurnOffAll();
        //An if statment thats taking the condition from the weather handler script and setting the corrisponding weather objects to active
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
