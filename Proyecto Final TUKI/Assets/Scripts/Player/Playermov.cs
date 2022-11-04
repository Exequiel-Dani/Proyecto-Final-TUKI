using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermov : MonoBehaviour
{
    public float rotationSpeed = 120f;
    //public CharacterController player;
    private float horizontalMove;
    private float verticalMove;
    private float rotationY;
    private float rotationX;
    public float playerSpeed = 10;
    private Camera camara;
    //private int jumpsLimit;
    //public int jumpsCant;
    //private bool isJumping;
    
    
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        //player = GetComponent<CharacterController>();
        //jumpForce = 400f;
        //jumpsCant = 0;
        //jumpsLimit = 1;
        //isJumping = false;
        //canJump = true;
        
        camara = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");
        rotationX = Input.GetAxis("Mouse X");
        rotationY = Input.GetAxis("Mouse Y");
        transform.Translate(new Vector3 (horizontalMove,0f,verticalMove) * playerSpeed * Time.deltaTime);
        transform.Rotate(new Vector3(0, rotationX, 0f) * rotationSpeed * Time.deltaTime);
        camara.transform.Rotate(new Vector3(-rotationY, 0, 0f) * rotationSpeed * Time.deltaTime);
        /*if (jumpsCant > jumpsLimit)
        {
            canJump = false;
            jumpsCant = 0;
        }
        if (jumpsCant <= jumpsLimit)
        {
            canJump = true;
        }*/

    }

    
}
