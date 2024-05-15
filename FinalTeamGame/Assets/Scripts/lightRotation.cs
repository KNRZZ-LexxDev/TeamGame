using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightRotation : MonoBehaviour
{
    public float RotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime);
    }
}
