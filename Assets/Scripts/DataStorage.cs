using System.Collections.Generic;
using UnityEngine;
public class DataStorage : MonoBehaviour
{
    public Transform p_medKits;
    //Array of GameObjects (Transform) which we assigned in inspector
    [Header("Location List \n")]
    [SerializeField] private Transform[] _medKits;
    [SerializeField] private Transform[] _bed;
    [SerializeField] private Transform[] _foodStorage;
    [SerializeField] private Transform[] _kitchen;
    [SerializeField] private Transform[] _seats;
    [SerializeField] private Transform[] _wc;
    [SerializeField] private Transform[] _lightSwitcher; //if provide changing day and night
    [SerializeField] private Transform[] _workPlace; //computers
    [SerializeField] private Transform[] _entertainmentArea; //recreation area

    //List of GameObject positions
    protected List<Vector3> medKits;
    protected List<Vector3> bed;
    protected List<Vector3> foodStorage;
    protected List<Vector3> kitchen;
    protected List<Vector3> seats;
    protected List<Vector3> wc;
    protected List<Vector3> lightSwitcher; //if provide changing day and night
    protected List<Vector3> workPlace; //computers
    protected List<Vector3> entertainmentArea; //recreation area

    [Space]

    [Header("AI Parameters")]
    [SerializeField]
    [Range(0f, 100f)] private float _hP;
    [SerializeField]
    [Range(0f, 100f)] private float _energy;
    [SerializeField]
    [Range(0f, 100f)] private float _hunger;
    [SerializeField]
    [Range(0f, 100f)] private float _thirst;
    [SerializeField]
    [Range(0f, 100f)] private float _exhausted;
    [SerializeField]
    [Range(0f, 100f)] private float _wC;
    [SerializeField]
    [Range(0f, 100f)] private float _workDemand;
    [SerializeField]
    [Range(0f, 100f)] private float _lightDemand;
    [SerializeField]
    [Range(0f, 100f)] private float _mentalHP;


    private void Start()
    {
        AddPositionsToList(_medKits, medKits, p_medKits);
        //AddPositionsToList(_foodStorage, foodStorage);
        //AddPositionsToList(_kitchen, kitchen);
        //AddPositionsToList(_seats, seats);
        //AddPositionsToList(_wc, wc);
        //AddPositionsToList(_lightSwitcher, lightSwitcher);
        //AddPositionsToList(_workPlace, workPlace);
        //AddPositionsToList(_entertainmentArea, entertainmentArea);

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

    private void AddPositionsToList(Transform[] _transforms, List<Vector3> list, Transform parent)
    {
        _transforms = parent.GetComponentsInChildren<Transform>();
        list = new List<Vector3>();
        foreach (Transform transform in _transforms)
        {
            list.Add(transform.position);
        }
    }

}
