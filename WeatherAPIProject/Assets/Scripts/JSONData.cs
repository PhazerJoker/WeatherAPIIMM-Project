using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Custom Classes
[System.Serializable]
public class CurrentWeather
{
    //The actual class that the APIPull is pulling from
    //Place pulls lon and lat to create a new instance of Place
    public Place coord = new Place();
    //Pulling from the weather class and making a list of the current Weather in a new instance
    public Weather[] weather = new Weather[1];
    //Pulling from the Main class to get all the basic data of the weather in a new instance
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