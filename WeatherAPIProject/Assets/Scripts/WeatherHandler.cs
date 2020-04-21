using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherHandler : MonoBehaviour
{
    //Creating instances of the WeatherDecider and WindmillScript
    public WeatherDecider weatherDecider;
    public WindmillSpeed windmillSetSpeed;
    public void SetTheWeather(CurrentWeather weather)
    {
        //Pulling information from the JSONData and getting the specific thing we are looking for and sending them to the scripts they need to go to
        weatherDecider.Setweather(weather.weather[0].main);

        windmillSetSpeed.setSpeed(weather.wind.speed);

    }
}
