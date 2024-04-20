using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public float acceleration = 10f;

    private bool isJumping;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isJumping = false;
    }

    void Update()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        // Перемещение по горизонтали
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(moveInput * moveSpeed, rb.velocity.y);

        // Прыжок
        if (Input.GetKeyDown(KeyCode.Space) && isJumping == false)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isJumping = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        isJumping = false;
    }
}
