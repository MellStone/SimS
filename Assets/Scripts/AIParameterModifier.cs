using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIParameterModifier : MonoBehaviour
{
    public static AIParameterModifier Instance;

    private DataStorage dataStorage;

    private void Start()
    {
        dataStorage = DataStorage.Instance;
    }
    void HPIncreaser()
    {
        dataStorage._hP += 3;
    }
    void HPOutcreaser()
    {
        dataStorage._hP -= 1;
    }
    void HPManager()
    {

    }
    
}
