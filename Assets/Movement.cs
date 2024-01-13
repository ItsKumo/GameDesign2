using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    
    Vector3 moveDirection;
    float Horizontalinput;
    float Verticalinput;
    public Transform orientation;
    
    public float runSpeed;
    
    Rigidbody rb;

    //int jumpCharges;


    //bool isGrounded;
    

    //float gravity;
    //public float normalGravity;

    //public float jumpHeight;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void HandleInput()
    {
        Horizontalinput = Input.GetAxisRaw("Horizontal");
        Verticalinput = Input.GetAxisRaw("Vertical");
    }

    // Update is called once per frame
    void Update()
    {
        HandleInput();
        
    }

    private void FixedUpdate()
    {
        GroundedMovement();
    }

    private void GroundedMovement()
    {
        moveDirection = orientation.forward *Verticalinput + orientation.right * Horizontalinput;
        rb.AddForce(moveDirection.normalized * runSpeed * 10f, ForceMode.Force);
    }

    /*void checkGround()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, 0.2f, groundMask);
        if (isGrounded)
        {
            jumpCharges = 1;
        }
    }

    void applyGravity()
    {
        gravity = normalGravity;
        velocityY.y += gravity * Time.deltaTime;
        controller.Move(velocityY * Time.deltaTime);
    }

    void Jump()
    {
        velocityY.y = Mathf.Sqrt(jumpHeight * -2f * normalGravity);
    }

    void Crouch()
    {
        controller.height = crouchHeight;
        controller.center = crouchingCenter;
        transform.localScale = new Vector3(transform.localScale.x, crouchHeight, transform.localScale.z);
        isCrouching = true;
    }

    void ExitCrouch()
    {
        controller.height = startHeight * 2;
        controller.center = standingCenter;
        transform.localScale = new Vector3(transform.localScale.x, startHeight, transform.localScale.z);
        isCrouching = false;
    }

    void AirMovement()
    {
        move.x += input.x * airSpeed;
        move.z += input.x * airSpeed;
    }*/
}