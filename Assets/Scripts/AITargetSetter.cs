using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AITargetSetter : MonoBehaviour
{
    protected NavMeshAgent agent;
    public GameObject[] _waypoints;
    public GameObject target;
    // Start is called before the first frame update
    public void SetTarget()
    {
        //target =
        agent.SetDestination(target.transform.position);
        if (Vector3.Distance(transform.position, target.transform.position) < 1f)
        {
            //
        }
    }
}
