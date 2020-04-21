using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherHandler : MonoBehaviour
{
    public WeatherDecider weatherDecider;
    public WindmillSpeed windmillSetSpeed;
    public void SetTheWeather(CurrentWeather weather)
    {
        weatherDecider.Setweather(weather.weather[0].main);

        windmillSetSpeed.setSpeed(weather.wind.speed);

    }
}
