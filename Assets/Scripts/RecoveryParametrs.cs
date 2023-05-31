using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecoveryParametrs : MonoBehaviour
{

    public DataStorage data;
    [SerializeField] bool isHP;
    [SerializeField] bool isEntertainment;
    [SerializeField] bool isKitchen;
    [SerializeField] bool isWC;
    [SerializeField] bool isBed;
    [SerializeField] bool isWorkPlace;

    [SerializeField] float regenSpeed = 50;

    private void Start()
    {

    }
    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Worl");
        IsParameters();
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