using UnityEngine;

public class Spring : MonoBehaviour
{
    [Header("Упругость батута")]
    [Space]
    [SerializeField] private float _force;

    public AudioClip jump;
    AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody != null)
        {
            audioSource.PlayOneShot(jump, 0.5F);
            collision.rigidbody.AddForce(Vector3.up * _force, ForceMode.Impulse);
        }
    }
}