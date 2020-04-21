using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherHandler : MonoBehaviour
{
    public WeatherDecider weatherDecider;
    public WindmillScript windmillScript;
    public void SetTheWeather(CurrentWeather weather)
    {
        weatherDecider.Setweather(weather.weather[0].main);

        windmillScript.WindmillSpeed(weather.wind.speed);

    }
}
