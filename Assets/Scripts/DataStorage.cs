using System.Collections.Generic;
using UnityEngine;
public class DataStorage : MonoBehaviour
{
    const float  maxValue = 100f;
    const float minValue = 0.0f;

    [Header("Location List \n")]
    [SerializeField] private GameObject p_medKits;
    [SerializeField] private GameObject p_bed;
    [SerializeField] private GameObject p_foodStorage;
    [SerializeField] private GameObject p_kitchen;
    [SerializeField] private GameObject p_seats;
    [SerializeField] private GameObject p_wc;
    [SerializeField] private GameObject p_lightSwitcher; //if provide changing day and night
    [SerializeField] private GameObject p_workPlace; //computers
    [SerializeField] private GameObject p_entertainmentArea; //recreation area

    //Array of GameObjects (Transform) which we assigned in inspector
    //[SerializeField] private Transform[] _medKits;
    //[SerializeField] private Transform[] _bed;
    //[SerializeField] private Transform[] _foodStorage;
    //[SerializeField] private Transform[] _kitchen;
    //[SerializeField] private Transform[] _seats;
    //[SerializeField] private Transform[] _wc;
    //[SerializeField] private Transform[] _lightSwitcher; //if provide changing day and night
    //[SerializeField] private Transform[] _workPlace; //computers
    //[SerializeField] private Transform[] _entertainmentArea; //recreation area

    //List of GameObject positions
    public List<Vector3> medKits;
    public List<Vector3> bed;
    public List<Vector3> foodStorage;
    public List<Vector3> kitchen;
    public List<Vector3> seats;
    public List<Vector3> wc;
    public List<Vector3> lightSwitcher; //if provide changing day and night
    public List<Vector3> workPlace; //computers
    public List<Vector3> entertainmentArea; //recreation area

    [Space]

    [Header("AI Parameters")]
    [SerializeField]
    [Range(minValue, maxValue)] private float _hP;
    [SerializeField]
    [Range(minValue, maxValue)] private float _energy;
    [SerializeField]
    [Range(minValue, maxValue)] private float _hunger;
    [SerializeField]
    [Range(minValue, maxValue)] private float _thirst;
    [SerializeField]
    [Range(minValue, maxValue)] private float _exhausted;
    [SerializeField]
    [Range(minValue, maxValue)] private float _wC;
    [SerializeField]
    [Range(minValue, maxValue)] private float _workDemand;
    [SerializeField]
    [Range(minValue, maxValue)] private float _lightDemand;
    [SerializeField]
    [Range(minValue, maxValue)] private float _mentalHP;


    private void Awake()
    {
        AddPositionsToList(p_medKits, medKits);
        AddPositionsToList(p_foodStorage, foodStorage);
        AddPositionsToList(p_kitchen, kitchen);
        AddPositionsToList(p_seats, seats);
        AddPositionsToList(p_wc, wc);
        AddPositionsToList(p_lightSwitcher, lightSwitcher);
        AddPositionsToList(p_workPlace, workPlace);
        AddPositionsToList(p_entertainmentArea, entertainmentArea);
    }

    public void ManagerHP(float p_value, bool isPlus)
    {
        _hP += isPlus ? p_value : -p_value;
    }
    public void ManagerEnergy(float p_value, bool isPlus)
    {
        _energy += isPlus ? p_value : -p_value;
    }
    public void ManagerHunger(float p_value, bool isPlus)
    {
        _hunger += isPlus ? p_value : -p_value;
    }
    public void ManagerThirst(float p_value, bool isPlus)
    {
        _thirst += isPlus ? p_value : -p_value;
    }
    public void ManagerExhausted(float p_value, bool isPlus)
    {
        _exhausted += isPlus ? p_value : -p_value;
    }
    public void ManagerWC(float p_value, bool isPlus)
    {
        _wC += isPlus ? p_value : -p_value;
    }
    public void ManagerWorkDemand(float p_value, bool isPlus)
    {
        _workDemand += isPlus ? p_value : -p_value;
    }
    public void ManagerLightDemand(float p_value, bool isPlus)
    {
        _lightDemand += isPlus ? p_value : -p_value;
    }
    public void ManagerMentalHP(float p_value, bool isPlus)
    {
        _mentalHP += isPlus ? p_value : -p_value;
    }

    private void AddPositionsToList(GameObject parent, List<Vector3> list)
    {
        if (parent != null)
        {
            var child = parent.GetComponentsInChildren<Transform>();
            foreach (Transform _transform in child)
            {
                list.Add(_transform.position);
            }
        }
        else return;
    }
}
