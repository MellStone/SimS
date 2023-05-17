using UnityEngine;
public class AIController : MonoBehaviour
{
    private AIParameterModifier parameterModifier;
    private AITargetSetter targetSetter;
    private Animator animator;
    void Start()
    {
        parameterModifier = GetComponent<AIParameterModifier>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        parameterModifier.ManagerHP();
        parameterModifier.ManagerThirst();
        parameterModifier.ManagerHunger();
        parameterModifier.ManagerEnergy();
        parameterModifier.ManagerExhausted();
        parameterModifier.ManagerWC();
        parameterModifier.ManagerWorkDemand();
        parameterModifier.ManagerMentalHP();
        parameterModifier.MangerLightDemand();
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
