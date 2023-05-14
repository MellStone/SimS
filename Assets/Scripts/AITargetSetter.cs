using UnityEngine;
using UnityEngine.AI;

public class AITargetSetter : DataStorage
{
    public DataStorage dataStorage;
    protected NavMeshAgent agent;
    public GameObject[] _waypoints;
    public GameObject target;
    // Start is called before the first frame update
    private void Start()
    {
        dataStorage = GetComponent<DataStorage>();
        foreach (Vector3 i in seats)
        {
            
        }
    }
    public void SetTarget()
    {

        agent.SetDestination(target.transform.position);
        if (Vector3.Distance(transform.position, target.transform.position) < 1f)
        {
            //target.transform.position = 
        }
    }
}
