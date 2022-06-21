using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float movementSpeed=6f;
    public float jumpForce=5f;
    
    public Transform groundCheck;
    public LayerMask ground;

    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float  horizontalInput=Input.GetAxis("Horizontal");
        float verticalInput=Input.GetAxis("Vertical");

        rb.velocity=new Vector3(horizontalInput*movementSpeed, rb.velocity.y, verticalInput*movementSpeed);

        if(Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity= new Vector3(rb.velocity.x,jumpForce,rb.velocity.z);
        }
        
    }

    
    bool IsGrounded()
    {
      return Physics.CheckSphere(groundCheck.position, .1f, ground);
    }
    
}