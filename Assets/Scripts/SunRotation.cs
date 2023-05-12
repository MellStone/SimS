using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class SunRotation : MonoBehaviour
{
    [SerializeField]
    private float speedRotation;

    private void Update()
    {
        transform.Rotate(1f * speedRotation * Time.deltaTime, 0f, 0f, Space.World);
    }
}
