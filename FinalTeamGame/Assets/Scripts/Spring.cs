using UnityEngine;

public class Spring : MonoBehaviour
{
    [Header("Упругость батута")]
    [Space]
    [SerializeField] private float _force;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.GetContact(0).normal);
        if (collision.rigidbody != null)
        {
            collision.rigidbody.AddForce(Vector3.up * _force, ForceMode.Impulse);
        }
    }
}