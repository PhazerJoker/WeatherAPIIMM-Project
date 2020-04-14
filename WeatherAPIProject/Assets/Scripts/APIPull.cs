using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class APIPull : MonoBehaviour
{
    public string city;
    public string state;
    string url;
    public CurrentWeather currentWeather;
    void Start()
    {
        AquireWeather();
    }

    public void AquireWeather()
    {
        AquireWeather(15218);
    }
    public void AquireWeather(string city, string state)
    {
        url = "http://api.openweathermap.org/data/2.5/weather?q=" + city + "," + state + "&appid=529b090848369d167a6b1f9acbbf1c0c";
        StartCoroutine(GetRequest(url));
    }
    public void AquireWeather(int zip)
    {
        url = "http://api.openweathermap.org/data/2.5/weather?zip=" + zip.ToString() + "&appid=529b090848369d167a6b1f9acbbf1c0c";
        StartCoroutine(GetRequest(url));
    }
    public void AquireWeather(string city)
    {
        url = "http://api.openweathermap.org/data/2.5/weather?q=" + city + "&appid=529b090848369d167a6b1f9acbbf1c0c";
        StartCoroutine(GetRequest(url));
    }
    IEnumerator GetRequest(string url)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(url))
        {
            //Request and wait for the desired url data
            yield return webRequest.SendWebRequest();

            if (webRequest.isNetworkError)
            {
                Debug.Log("Error" + webRequest.error);
            }
            else
            {
                currentWeather = JsonUtility.FromJson<CurrentWeather>(webRequest.downloadHandler.text);
            }
        }
        //TO DO:Make events happen (Carter)
    }
}
