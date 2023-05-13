using System.Collections.Generic;
using UnityEngine;

public class DataStorage : MonoBehaviour
{

    [Header("Location List \n")]
    [SerializeField] protected List<GameObject> medKits = new List<GameObject>();
    [SerializeField] protected List<GameObject> bed = new List<GameObject>();
    [SerializeField] protected List<GameObject> foodStorage = new List<GameObject>();
    [SerializeField] protected List<GameObject> kitchen = new List<GameObject>();
    [SerializeField] protected List<GameObject> seats = new List<GameObject>();
    [SerializeField] protected List<GameObject> wc = new List<GameObject>();
    [SerializeField] protected List<GameObject> lightSwitcher = new List<GameObject>(); //if provide changing day and night
    [SerializeField] protected List<GameObject> workPlace = new List<GameObject>(); //computers
    [SerializeField] protected List<GameObject> entertainmentArea = new List<GameObject>(); //recreation area

    [Space]

    [Header("AI Parameters")]
    [SerializeField]
    [Range(0f, 100f)] public float _hP;
    [SerializeField]
    [Range(0f, 100f)] public float _energy;
    [SerializeField]
    [Range(0f, 100f)] public float _hunger;
    [SerializeField]
    [Range(0f, 100f)] public float _thirst;
    [SerializeField]
    [Range(0f, 100f)] public float _exhausted;
    [SerializeField]
    [Range(0f, 100f)] public float _wc;
    [SerializeField]
    [Range(0f, 100f)] public float _workDemand;
    [SerializeField]
    [Range(0f, 100f)] public float lightDemand;
    [SerializeField]
    [Range(0f, 100f)] public float mentalHP;
}
