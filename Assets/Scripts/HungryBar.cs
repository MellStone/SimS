using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungryBar : MonoBehaviour
{
    public Slider hungerSlider;
    public DataStorage data;
    protected const float MAXVALUE = 100f;
    private void Update()
    {
        UpdateHungerUI();
    }
    private void UpdateHungerUI()
    {
        float hungerPercentage = data.HP / MAXVALUE;
        hungerSlider.value = hungerPercentage;
    }
}
