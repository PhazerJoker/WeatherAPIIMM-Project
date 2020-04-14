using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Custom Class
[System.Serializable]
public class CurrentWeather
{
    public Place coord = new Place();
    public Weather[] weather = new Weather[1];
    public Main main = new Main();
}
[System.Serializable]
public class Place
{
    public double lon;
    public double lat;
}
[System.Serializable]
public class Weather
{
    public string main;
    public string description;
}
[System.Serializable]
public class Main
{
    public int temp;
    public int pressure;
    public int humidity;
}
[System.Serializable]
public class Wind
{
    public int speed;
    public int deg;
}
[System.Serializable]
public class Cloud
{
    public int all;
}


//http://api.openweathermap.org/data/2.5/weather?zip= + zip + &appid=529b090848369d167a6b1f9acbbf1c0c