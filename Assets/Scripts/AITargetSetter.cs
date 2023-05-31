using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.EventSystems.EventTrigger;

public class AITargetSetter : MonoBehaviour
{
    [SerializeField] private PriorityController priority;
    [SerializeField] private DataStorage data;
    [SerializeField] private NavMeshAgent agent;
    public Vector3 target;
    [SerializeField] private GameObject ai;
    [SerializeField] private Vector3 aiPosition;
    

    private void Update()
    {
        SetTarget();
    }

    public void SetTarget()
    {
        agent.SetDestination(ShortestTarget(ChoosePriority()));

    }

    private Vector3 ShortestTarget(List<Vector3> vectors)
    {
        if (vectors == null || vectors.Count == 0)
            return Vector3.zero;

        aiPosition = ai.transform.position;

        Vector3 shortestVector = vectors[0];
        float shortestDistance = Vector3.Distance(shortestVector, aiPosition);

        for (int i = 1; i < vectors.Count; i++)
        {
            float distance = Vector3.Distance(vectors[i], aiPosition);
            if (distance < shortestDistance)
            {
                shortestVector = vectors[i];
                shortestDistance = distance;
                target = shortestVector;
            }
        }
        return shortestVector;
    }
    List<Vector3> ChoosePriority()
    {
        switch (priority.priority)
        {
            case 0:
                return data.lightSwitcher;
            case 1:
                return data.entertainmentArea;
            case 2:
                return data.bed;
            case 3:
                return data.entertainmentArea;
            case 4:
                return data.workPlace;
            case 5:
                return data.wc;
            case 6:
                return data.kitchen;
            case 7:
                return data.kitchen;
            case 8:
                return data.medKits;
            default: return null;
        }
    }
}