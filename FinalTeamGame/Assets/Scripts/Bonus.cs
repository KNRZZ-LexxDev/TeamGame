using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    public PlayerController Player;


    public AudioClip wellDone;
    AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Player.OnCrouch();
            audioSource.PlayOneShot(wellDone, 0.5F);
            Invoke("DestroyPowerUp", 1);
        }
    }

    private void DestroyPowerUp()
    {
        Destroy(gameObject);
    }
}
