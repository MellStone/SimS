using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParametrRecovery : MonoBehaviour
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
    private void OnTriggerEnter(Collider other)
    {
        if (other != null)
        {
            IsParametrs();
        }
        Debug.Log("Work");
    }
    private void IsParametrs()
    {
        if (isHP)
        {
            data.HP = 100;
            Debug.Log("work");
        }
        if (isEntertainment)
        {
            data.MentalHP += Time.deltaTime * regenSpeed;
            data.Exhausted += Time.deltaTime * regenSpeed;
        }
        if (isKitchen)
        {
            data.Hunger += Time.deltaTime * regenSpeed;
            data.Thirst += Time.deltaTime * regenSpeed;
        }
        if (isWorkPlace)
        {
            data.WorkDemand += Time.deltaTime * regenSpeed;
        }
        if (isWC)
        {
            data.WC += Time.deltaTime * regenSpeed;
        }
        if (isBed)
        {
            data.Energy += Time.deltaTime * regenSpeed;
        }
    }
}
