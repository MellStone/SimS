using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.AI;
public class AIController : MonoBehaviour
{
    private DataStorage dataStorage;
    private AIParameterModifier parameterModifier;


    public GameObject   [] _waypoints;
    int currentTarget;
    public GameObject target;
    private NavMeshAgent agent;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        parameterModifier = AIParameterModifier.Instance;
        dataStorage = DataStorage.Instance;
        currentTarget = 0;
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        SetTarget();
    }
        
    private bool AchivedTarget()
    {
        if (Vector3.Distance(transform.position, target.transform.position) <= 1f)
        {
            animator.SetBool("isRunning", false);
            return true;    
        }
        else
        {
            animator.SetBool("isRunning", true);
            return false;
        }
    }

    private void SetTarget()
    {
        target = _waypoints[currentTarget];
        agent.SetDestination(target.transform.position);
        if (Vector3.Distance(transform.position, target.transform.position) < 1f)
        {
            //
        }
    }
}
