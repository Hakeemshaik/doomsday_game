using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Adjust the speed as needed.
    private Rigidbody rb; // Reference to the game object's Rigidbody.

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput) * moveSpeed;

        if (rb != null)
        {
            // If you have a Rigidbody, use physics-based movement.
            rb.velocity = movement;
        }
        else
        {
            // If you don't have a Rigidbody, use transform-based movement.
            transform.Translate(movement * Time.deltaTime);
        }
    } 
}
