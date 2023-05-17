using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunger : MonoBehaviour
{
    public float maxHunger = 100f;
    public float hungerDecreaseRate = 0.5f;

    public float currentHunger;

    private void Start()
    {
        currentHunger = maxHunger;
    }
    private void Update()
    {
        Decreasehunger();
    }
    private void Decreasehunger()
    {
        if(currentHunger > 0f)
        {
            currentHunger -= hungerDecreaseRate * Time.deltaTime;
        }
        else if (currentHunger < 0f)
        {
            Destroy(gameObject);
        }
    }

    public void IncreaseHunger(float amount)
    {
        currentHunger += amount;
        if (currentHunger > maxHunger)
        {
            currentHunger = maxHunger;
        }
    }
    
}
