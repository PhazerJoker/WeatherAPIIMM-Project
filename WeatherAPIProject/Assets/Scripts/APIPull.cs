using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class APIPull : MonoBehaviour
{
    [Header("Config")]
    public WeatherHandler handler;
    public string city;
    public string state;

    [Header("Debug")]

    //This variable is pulling from the CurrentWeather script to make a new instance of this variable
    public CurrentWeather currentWeather;

    //On start call upon the AquireWeather structs
    void Start()
    {
        AquireWeather();
    }

    //This is the default input if we dont get any from the user
    public void AquireWeather()
    {
        AquireWeather(15218);
    }
    //Getting options for how we pull the data from the website
    //The first possible pull is getting the city and state from the user 
    public void AquireWeather(string city, string state)
    {
        string url = "http://api.openweathermap.org/data/2.5/weather?q=" + city + "," + state + "&appid=529b090848369d167a6b1f9acbbf1c0c";
        StartCoroutine(GetRequest(url));
    }
    //The second possible pull is getting the zip code from the user as a int and converting it to a string
    public void AquireWeather(int zip)
    {
        string url = "http://api.openweathermap.org/data/2.5/weather?zip=" + zip.ToString() + "&appid=529b090848369d167a6b1f9acbbf1c0c";
        StartCoroutine(GetRequest(url));
    }
    //The last pull is getting the city name from the user, most simple input
    public void AquireWeather(string city)
    {
        string url = "http://api.openweathermap.org/data/2.5/weather?q=" + city + "&appid=529b090848369d167a6b1f9acbbf1c0c";
        StartCoroutine(GetRequest(url));
    }
    //Some copied code from unity documentation
    //This pulls from the url from the AquireWeather structs and sends a web request to get them

    IEnumerator GetRequest(string url)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(url))
        {
            //Request and wait for the desired url data
            yield return webRequest.SendWebRequest();
            //If webRequest does not return data send an error in the console
            if (webRequest.isNetworkError)
            {
                Debug.Log("Error" + webRequest.error);
            }
            //else take the data from the Json and put into the CurrentWeather structs
            else
            {
                currentWeather = JsonUtility.FromJson<CurrentWeather>(webRequest.downloadHandler.text);
                handler.SetTheWeather(currentWeather);
            }
        }
        //TO DO:Make events happen (Carter)
    }
}
