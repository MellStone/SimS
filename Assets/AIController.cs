using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AIController : MonoBehaviour
{
    public GameObject[] _waypoints;
    int currentTarget;
    public GameObject target;
    private NavMeshAgent agent;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        currentTarget = 0;
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentTarget)
        {
            case 0:
                SetTarget();
                break;
            case 1:
                SetTarget();
                break;
            case 2:
                SetTarget();
                break;
            case 3:
                SetTarget();
                break;
            case 4:
                currentTarget = 0;
                break;
        }

        if (Vector3.Distance(transform.position, target.transform.position) > 1f)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }
    }
    private void SetTarget()
    {
        target = _waypoints[currentTarget];
        agent.SetDestination(target.transform.position);
        if (Vector3.Distance(transform.position, target.transform.position) < 1f)
        {
            currentTarget++;
        }
    }
}
