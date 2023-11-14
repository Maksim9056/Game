using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 5f;
    public float accelerationMultiplier = 2f;
    public Transform cameraTransform; // Ссылка на трансформ камеры
    private Rigidbody2D rb;
    private bool isJumping = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        bool isShiftHeld = Input.GetKey(KeyCode.LeftShift);

        Vector2 movement = new Vector2(horizontalInput, verticalInput);

        if (isShiftHeld)
        {
            movement *= accelerationMultiplier;
        }

        rb.velocity = movement * speed;

        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            isJumping = true;
        }

        // Поворот камеры влево и вправо
        if (horizontalInput > 0)
        {
            cameraTransform.rotation = Quaternion.Euler(0, 0, 0); // Поворот камеры вправо
        }
        else if (horizontalInput < 0)
        {
            cameraTransform.rotation = Quaternion.Euler(0, 180, 0); // Поворот камеры влево
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
}
