using UnityEngine;
using UnityEngine.AI;

public class AITargetSetter : MonoBehaviour
{
    public DataStorage data; // why is assigned from AIParameterModifier
    protected NavMeshAgent agent;
    public GameObject[] _waypoints;
    public GameObject target;
    // Start is called before the first frame update
    private void Start()
    {
        data = GetComponent<DataStorage>();
        foreach (var i in this.data.seats)
        {
            Debug.Log(i);
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
