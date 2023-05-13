using System.Collections.Generic;
using UnityEngine;

public class DataStorage : MonoBehaviour
{
    public static DataStorage Instance;

    [Header("Location List \n")]
    public List<GameObject> medKits = new List<GameObject>();
    public List<GameObject> bed = new List<GameObject>();
    public List<GameObject> foodStorage = new List<GameObject>();
    public List<GameObject> kitchen = new List<GameObject>();
    public List<GameObject> seats = new List<GameObject>();
    public List<GameObject> wc = new List<GameObject>();
    public List<GameObject> lightSwitcher = new List<GameObject>(); //if provide changing day and night
    public List<GameObject> workPlace = new List<GameObject>(); //computers
    public List<GameObject> entertainmentArea = new List<GameObject>(); //recreation area
    
    [Space]

    [Header("AI Parameters")]
    [Range(0f, 100f)]
    public float _hP;
    [Range(0f, 100f)]
    public float _energy;
    [Range(0f, 100f)]
    public float _hunger;
    [Range(0f, 100f)]
    public float _thirst;
    [Range(0f, 100f)]
    public float _exhausted;
    [Range(0f, 100f)]
    public float _wc;
    [Range(0f, 100f)]
    public float _workDemand;
    [Range(0f, 100f)]
    public float _lightDemand;
    [Range(0f, 100f)]
    public float _mentalHP;
}