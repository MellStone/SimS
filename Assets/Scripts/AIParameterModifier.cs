using UnityEngine;

public class AIParameterModifier : DataStorage
{
    [SerializeField] private float hPSpeedDecreaser;
    DataStorage dataStorage;

    private void Start()
    {
        dataStorage = GetComponent<DataStorage>();
    }
    public void HP()
    {   
        this.ManagerHP(hPSpeedDecreaser, false); //just test
    }
}
