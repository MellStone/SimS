using System.Collections.Generic;
using UnityEngine;
public class DataStorage : MonoBehaviour
{
    protected const float MAXVALUE = 100f;
    protected const float MINVALUE = 0.0f;

    [Header("Location List \n")]
    [SerializeField] private GameObject m_medKits;
    [SerializeField] private GameObject m_bed;
    [SerializeField] private GameObject m_foodStorage;
    [SerializeField] private GameObject m_kitchen;
    [SerializeField] private GameObject m_seats;
    [SerializeField] private GameObject m_wc;
    [SerializeField] private GameObject m_lightSwitcher; //if provide changing day and night
    [SerializeField] private GameObject m_workPlace; //computers
    [SerializeField] private GameObject m_entertainmentArea; //recreation area

    [Space]
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
    [Range(MINVALUE, MAXVALUE)] private float _hP;
    [SerializeField]
    [Range(MINVALUE, MAXVALUE)] private float _energy;
    [SerializeField]
    [Range(MINVALUE, MAXVALUE)] private float _hunger;
    [SerializeField]
    [Range(MINVALUE, MAXVALUE)] private float _thirst;
    [SerializeField]
    [Range(MINVALUE, MAXVALUE)] private float _exhausted;
    [SerializeField]
    [Range(MINVALUE, MAXVALUE)] private float _wC;
    [SerializeField]
    [Range(MINVALUE, MAXVALUE)] private float _workDemand;
    [SerializeField]
    [Range(MINVALUE, MAXVALUE)] private float _mentalHP;
    [SerializeField]
    [Range(MINVALUE, MAXVALUE)] private float _lightDemand;

    public float HP { get => _hP; set => _hP = value; }
    public float Energy { get => _energy; set => _energy = value; }
    public float Hunger { get => _hunger; set => _hunger = value; }
    public float Thirst { get => _thirst; set => _thirst = value; }
    public float Exhausted { get => _exhausted; set => _exhausted = value; }
    public float WC { get => _wC; set => _wC = value; }
    public float WorkDemand { get => _workDemand; set => _workDemand = value; }
    public float MentalHP { get => _mentalHP; set => _mentalHP = value; }
    public float LightDemand { get => _lightDemand; set => _lightDemand = value; }


    private void Awake()
    {
        AddPositionsToList(m_medKits, medKits);
        AddPositionsToList(m_foodStorage, foodStorage);
        AddPositionsToList(m_kitchen, kitchen);
        AddPositionsToList(m_seats, seats);
        AddPositionsToList(m_wc, wc);
        AddPositionsToList(m_lightSwitcher, lightSwitcher);
        AddPositionsToList(m_workPlace, workPlace);
        AddPositionsToList(m_entertainmentArea, entertainmentArea);
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
