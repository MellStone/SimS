using UnityEngine;
public class AIController : MonoBehaviour
{
    private AIParameterModifier parameterModifier;
    private AITargetSetter targetSetter;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        parameterModifier = GetComponent<AIParameterModifier>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        parameterModifier.HP();        
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
