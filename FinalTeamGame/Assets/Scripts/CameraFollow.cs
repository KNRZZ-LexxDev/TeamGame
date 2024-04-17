using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;
    public float Speed;
    private Vector3 startOffset;


    private void Awake()
    {
        startOffset = transform.position - Target.position;   
    }

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, Target.position + startOffset, Time.deltaTime * Speed);
    }
}
