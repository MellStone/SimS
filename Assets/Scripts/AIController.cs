using UnityEngine;
public class AIController : AITargetSetter
{
    private AIParameterModifier parameterModifier;
    private AITargetSetter targetSetter;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        parameterModifier = new AIParameterModifier();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        parameterModifier.HPDecreaser();        
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
