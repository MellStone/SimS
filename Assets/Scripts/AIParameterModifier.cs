using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIParameterModifier : DataStorage
{
    [SerializeField]
    private float hPSpeedDecreaser;
    private DataStorage dataStorage;
    private void Start()
    {
        dataStorage = GetComponent<DataStorage>();
    }
    public void HPIncreaser()
    {
        dataStorage._hP += 3;
    }
    public void HPDecreaser()
    {
        if (dataStorage._hP > 0)
        {
            dataStorage._hP -= hPSpeedDecreaser * Time.deltaTime;
        }
    }
    public void HPManager()
    {

    }
    
}
