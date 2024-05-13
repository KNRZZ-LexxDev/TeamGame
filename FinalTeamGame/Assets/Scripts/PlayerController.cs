﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public float acceleration = 10f;
    public GameObject Leave;
    public GameObject SureLeave;
    public bool ActiveCrouch = false;
    AudioSource audioSource;

    public AudioClip jump;

    private bool isJumping;
    private Rigidbody rb;
    private bool isOpen;
    private Vector3 _startScale; //Чтобы знать размерчик сами понимаете
    private void Awake()
    {
        _startScale = transform.localScale;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        isJumping = false;
        isOpen = false;
    }

    void Update()
    {
        PlayerMovement();
        PlayerCrouch();
        PlayerPause();
    }

    private void PlayerMovement()
    {
        // Перемещение по горизонтали
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(moveInput * moveSpeed, rb.velocity.y);

        // Прыжок
        if (Input.GetKeyDown(KeyCode.Space) && isJumping == false)
        {
            audioSource.PlayOneShot(jump, 0.5F);
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isJumping = true;
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void PlayerCrouch()
    {
        if(ActiveCrouch == false)
        {
            return;
        }
        else
        {
            //Сжатие
            if (Input.GetKey(KeyCode.T))
            {
                transform.localScale = new Vector3(_startScale.x, _startScale.y * 0.5f, _startScale.z);
            }
            //Расширение
            if (Input.GetKeyUp(KeyCode.T))
            {
                transform.localScale = _startScale;
            }
        }
    }

    public void OnCrouch()
    {
        ActiveCrouch = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        isJumping = false;
    }

    private void PlayerPause()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SureLeave.activeSelf == true) return;
            Leave.SetActive(!Leave.activeSelf);
        }
    }

    public void PlayerContinue()
    {
        if (SureLeave.activeSelf == true)
        {
            PlayerSureLeave();
        }
        Leave.SetActive(!Leave.activeSelf);
    }

    public void PlayerSureLeave()
    {
        if(Leave.activeSelf == true)
        {
            PlayerContinue();
        }
        SureLeave.SetActive(!SureLeave.activeSelf);
    }
}
