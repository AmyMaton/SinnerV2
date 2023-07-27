using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject Player => player;
    private GameObject player;

    private Rigidbody playerRB;

    public float movementSpeed = 7.5f;
    public float stoppingForce = 12.0f;

    private Vector2 movement;

    private void Awake()
    {
        player = this.gameObject;
        playerRB = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

         movement = new Vector2(horizontalInput, verticalInput).normalized * movementSpeed;

        playerRB.velocity = movement;
    }

    private void FixedUpdate()
    {
        if (movement.magnitude == 0f && playerRB.velocity.magnitude > 0f)
        {
            Vector2 stopForce = -playerRB.velocity * stoppingForce;
            playerRB.AddForce(stopForce);
        }
    }
}
