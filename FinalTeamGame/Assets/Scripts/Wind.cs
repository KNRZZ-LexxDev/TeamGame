using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    public float WindForce;
    public ParticleSystem particles;
    public BoxCollider boxcollider;

    private void Awake()
    {
        particles = GetComponentInChildren<ParticleSystem>();
        boxcollider = GetComponent<BoxCollider>();
        var shape = particles.shape;
        shape.scale = transform.localScale; 
    }

    private void OnTriggerStay(Collider collider)
    {
        if (collider.TryGetComponent<Rigidbody>(out var rb))
        {
            Debug.Log("sss");
            rb.AddForce(transform.up * WindForce * Time.fixedDeltaTime);
        }
    }
}
