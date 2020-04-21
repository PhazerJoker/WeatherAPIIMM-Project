using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherHandler : MonoBehaviour
{
    public WeatherDecider weatherDecider;

    public void SetTheWeather(CurrentWeather weather)
    {
        weatherDecider.Setweather(weather.weather[0].main);

        //call the windmill setspeed function

    }
}
