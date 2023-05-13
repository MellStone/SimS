using UnityEngine;

public class AIParameterModifier : MonoBehaviour
{
    [SerializeField] private float hPSpeedDecreaser;
    [SerializeField] public DataStorage data;

    private void Start()
    {
        data = GetComponent<DataStorage>();
    }

    public void HPIncreaser()
    {
        data._hP += 3;
    }

    public void HPDecreaser()
    {
        if (data._hP > 0)
        {
            data._hP -= hPSpeedDecreaser * Time.deltaTime;
        }
    }
}
