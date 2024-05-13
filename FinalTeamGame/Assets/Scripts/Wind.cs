using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    public float WindForce;
    public ParticleSystem particles;
    public BoxCollider boxcollider;
    public string windDirection;

    public AudioClip windSound;
    AudioSource audioSource;

    private void Awake()
    {
        particles = GetComponentInChildren<ParticleSystem>();
        boxcollider = GetComponent<BoxCollider>();
        var shape = particles.shape;
        shape.scale = transform.localScale;
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerStay(Collider collider)
    {
        if (collider.TryGetComponent<Rigidbody>(out var rb_up) && windDirection == "UP")
        {
            rb_up.AddForce(transform.up * WindForce * Time.fixedDeltaTime);
        }

        if (collider.TryGetComponent<Rigidbody>(out var rb_forward) && windDirection == "RIGHT")
        {
            rb_forward.AddForce(transform.right * WindForce * Time.fixedDeltaTime);
        }

        audioSource.PlayOneShot(windSound, 0.2F);
    }
}
