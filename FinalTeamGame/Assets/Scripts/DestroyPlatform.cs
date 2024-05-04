using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
    public float Timer;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Invoke("DestroyPlatformOnGame", Timer);
        }
    }

    private void DestroyPlatformOnGame()
    {
        Destroy(gameObject);
    }
}
