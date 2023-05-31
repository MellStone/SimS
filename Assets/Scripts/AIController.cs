using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class AIController : MonoBehaviour
{
    [SerializeField]private AIParameterModifier parameterModifier;
    [SerializeField] private AITargetSetter targetSetter;
    [SerializeField]private Animator animator;
    void Start()
    {
        targetSetter = GetComponent<AITargetSetter>();
        parameterModifier = GetComponent<AIParameterModifier>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        Animation();
        UpdateParameters();
    }

    private void UpdateParameters()
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

    private void Animation()
    {
        if (Vector3.Distance(transform.position, targetSetter.target) >= 1f)
        {
            animator.SetBool("isRunning", true);    
        }
        else animator.SetBool("isRunning", false);
    }
}
