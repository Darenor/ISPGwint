using UnityEngine;

[CreateAssetMenu(fileName = "WeatherCard",
    menuName = "Cards/Weather")]
public class WeatherCard : Card, IWeatherCard
{
    public void ApplyWeatherEffect()
    {
        Debug.Log("Применён погодный эффект Мгла!");
    }

    public override void Apply()
    {
        ApplyWeatherEffect();
    }
}
