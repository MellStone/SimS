using UnityEngine;
using UnityEngine.AI;
using System.Collections.Generic;

public class AITargetSetter : MonoBehaviour
{
    [SerializeField] private PriorityController priority;
    [SerializeField] private DataStorage data;
    [SerializeField] private NavMeshAgent agent;
    public GameObject target;
    [SerializeField] private Vector3 playerPositon;

    private void Start()
    {
        
    }
    private void Update()
    {
        
    }
    public void SetTarget()
    {
        agent.SetDestination(target.transform.position);
        if (Vector3.Distance(transform.position, target.transform.position) < 1f)
        {
            //target.transform.position = 
        }
    }
    private int PriorityCheck()
    {
        switch (priority.priority)
        {
            case (int)ParameterType.HP:

                break;
        }
        int k =1;
        return k;
    }
    private Vector3 ShortestWay(Vector3[] m_postions)
    {
        List<float> shorts = new List<float>();
        Vector3 shortestTarget = Vector3.one;
        foreach (Vector3 target in m_postions)
        {
            shorts.Add(Vector3.Distance(target, playerPositon));
        }
        foreach(float targerts in shorts)
        {
            if (targerts < 0)
            { }
        }
        return shortestTarget;
    }
}