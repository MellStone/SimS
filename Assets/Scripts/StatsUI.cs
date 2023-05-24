using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsUI : MonoBehaviour
{
    private float hPPercentage;
    private float energyPercentage;
    private float hungerPercentage;
    private float thirstPercentage;
    private float exhaustedPercentage;
    private float wCPercentage;
    private float mentalHPPercentage;
    private float workDemandPercentage;
    private float lightDemandPercentage;
    
    public DataStorage data;
    Slider slider;
    protected const float MAXVALUE = 100f;

    private void Start()
    {
        slider = GetComponent<Slider>();
    }
    private void Update()
    {
        UpdateUI(data.HP, slider);
        UpdateUI(data.Energy, slider);
        UpdateUI(data.Hunger, slider);
        UpdateUI(data.Thirst, slider);
        UpdateUI(data.WC, slider);
        UpdateUI(data.WorkDemand, slider);
        UpdateUI(data.Exhausted, slider);
        UpdateUI(data.MentalHP, slider);
        UpdateUI(data.LightDemand, slider);
    }

    public void UpdateUI(float value, Slider slider)
    {
        float percentage = value / MAXVALUE;
        slider.value = percentage;
    }
}
