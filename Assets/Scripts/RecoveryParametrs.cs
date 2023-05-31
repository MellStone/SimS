using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecoveryParametrs : MonoBehaviour
{
    [SerializeField] DataStorage data;
    [SerializeField] bool isHP;
    [SerializeField] bool isEntertainment;
    [SerializeField] bool isKitchen;
    [SerializeField] bool isWC;
    [SerializeField] bool isBed;
    [SerializeField] bool isWorkPlace;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("wokrl");
    }
    private void IsParameters()
    {
        if (isHP)
        {
            data.HP = 100;
            Debug.Log("work");
        }
        if (isEntertainment)
        {
            data.MentalHP = 100;
            data.Exhausted = 100;
        }
        if (isKitchen)
        {
            data.Hunger = 100;
            data.Thirst = 100;
        }
        if (isWorkPlace)
        {
            data.WorkDemand = 100;
        }
        if (isWC) 
        {
            data.WC = 100;
        }
        if (isBed)
        {
            data.Energy = 100;
        }
    }
}
