using System.Collections;
using UnityEngine;

public class PriorityController : MonoBehaviour
{
    [SerializeField] private DataStorage data;
    [SerializeField] public int priority;

    private void Start()
    {
        StartCoroutine(PriorityCoroutine());
    }
    private IEnumerator PriorityCoroutine()
    {
        do
        {
            data.UpdateParameters();
            for (int i = 0; i < data.Parameters.Count; i++)
            {
                if (data.Parameters[i] <= 70)
                {
                    priority = i;
                }
            }
            Debug.Log("Now priority is: " + priority);
            yield return new WaitForSeconds(5f);
        } while (true);
    }
}
