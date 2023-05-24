using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class AITargetSetter : MonoBehaviour
{
    [SerializeField] private PriorityController priority;
    [SerializeField] private DataStorage data;
    [SerializeField] private NavMeshAgent agent;
    public GameObject target;

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
            case 0:

                break;
        }
        int k =1;
        return k;
    }
}