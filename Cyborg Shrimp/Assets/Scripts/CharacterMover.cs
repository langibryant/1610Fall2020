using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{

    public CharacterController controller;
    public float moveSpeed = 3f, gravity = -9.81f, jumpForce = 1f;

    private Vector3 moveDirection, movement;
    public float yDirection;
    
    // Update is called once per frame
    void Update()
    {
        var moveSpeedInput = moveSpeed * Input.GetAxis("Horizontal");

        moveDirection.Set(moveSpeedInput, yDirection, 0);

        yDirection += gravity*Time.deltaTime;

        if (controller.isGrounded && moveDirection.y < 0)
        {
            yDirection = -1f;
        }
        
        if (Input.GetButton("Jump"))
        {
            yDirection += jumpForce;
        }
        

        movement = moveDirection * Time.deltaTime;
        controller.Move(movement);
    }
}
