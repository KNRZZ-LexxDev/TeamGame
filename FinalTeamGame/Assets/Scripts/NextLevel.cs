using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevel : MonoBehaviour
{
    public int SceneNum;

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
            audioSource.PlayOneShot(wellDone, 0.5F);
            Invoke("LoadNextScene", 2);     
        }
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(SceneNum);
    }
}
