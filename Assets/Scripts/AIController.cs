using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.AI;
public class AIController : AITargetSetter
{
    private AIParameterModifier parameterModifier;
    private AITargetSetter targetSetter;
    
    int currentTarget;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        currentTarget = 0;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (parameterModifier != null)
        {
            parameterModifier.HPDecreaser();
        }

        if (targetSetter != null)
        {
            targetSetter.SetTarget();
        }
    }


    private bool AchivedTarget()
    {
        if (Vector3.Distance(transform.position, targetSetter.target.transform.position) <= 1f)
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

    
}
