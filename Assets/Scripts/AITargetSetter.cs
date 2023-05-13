using UnityEngine;
using UnityEngine.AI;

public class AITargetSetter : DataStorage
{
    AITargetSetter dataStorage;
    protected NavMeshAgent agent;
    public GameObject[] _waypoints;
    public GameObject target;
    // Start is called before the first frame update
    public void SetTarget()
    {

        agent.SetDestination(target.transform.position);
        if (Vector3.Distance(transform.position, target.transform.position) < 1f)
        {
            //target.transform.position = 
        }
    }
}
