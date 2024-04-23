using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopePart : MonoBehaviour
{
    public Rigidbody rb;
    public HingeJoint hingeJoint;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        hingeJoint = GetComponent<HingeJoint>();
    }
}
