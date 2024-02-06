using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    //references this script to character controller component in unity
    public CharacterController controller;

    //public variable to determine speed for movement
    public float speed = 12f;

    // public variable defining gravity
    public float gravity = -9.81f;

    //variable defining the players jump height
    public float jumpHeight = 3f;

    //public transform relating to the groundcheck for jumping
    public Transform groundCheck;

    //checks against walls
    //public Transform wallCheck;

    //defines distance from ground
    public float groundDistance = 0.4f;

    //defines what is considered ground for the ground check
    public LayerMask groundMask;

    //stores velocity for movement
    Vector3 velocity;

    //bool to determine if grounded is true or not
    bool isGrounded;

    

    // Update is called once per frame
    void Update()
    {
        //checks if player is grounded
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        //if player had fell and stayed on ground, reset y velocity to 0
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = 0f;
        }

        //gets input from WASD keys 
        //float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //turns input into movement 
        Vector3 move =  transform.forward * z;

        //moves player based on the vector, speed and the delta time
        controller.Move(move * speed * Time.deltaTime);

        //checks if jump key is pressed aswell as if player is grounded. jump key defined in unity standard controls
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            //applies upward velocity simulating a jump
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }


        //applies gravity over time to y axis movement
        velocity.y += gravity * Time.deltaTime;

        //moves player based on the vector, speed and the delta time
        controller.Move(velocity * Time.deltaTime);

        
    }
}
