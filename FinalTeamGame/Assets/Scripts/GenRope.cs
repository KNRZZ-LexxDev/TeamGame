using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenRope : MonoBehaviour
{
    public RopePart ropePart;
    public int partCount;
    private RopePart[] parts;
    private void Awake()
    {
        parts = new RopePart[partCount];
        for( int i = 0; i < partCount; i++)
        {
            parts[i] = Instantiate(ropePart, transform);
            parts[i].transform.position = transform.position - transform.up * i * parts[i].transform.localScale.y * 2;
            if(i > 0)
            {
                parts[i].hingeJoint.connectedBody = parts[i - 1].rb;
            }
        }
    }
}
