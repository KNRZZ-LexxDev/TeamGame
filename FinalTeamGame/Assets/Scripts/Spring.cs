using UnityEngine;

public class Spring : MonoBehaviour
{
    [Header("Упругость батута")]
    [Space]
    [SerializeField] private float _force;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody != null)
        {
            collision.rigidbody.AddForce(Vector3.up * _force, ForceMode.Impulse);
        }
    }
}