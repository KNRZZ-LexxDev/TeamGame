using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimePlatfrom : MonoBehaviour
{
    public float Timer;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Invoke("DropPlatform", Timer);
        }
    }

    public void DropPlatform()
    {
        gameObject.AddComponent<Rigidbody>();
    }
}
