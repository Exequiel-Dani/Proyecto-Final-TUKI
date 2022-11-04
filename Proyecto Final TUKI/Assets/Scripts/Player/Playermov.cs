using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermov : MonoBehaviour
{
    private float rotationSpeed = 85f;
    //public CharacterController player;
    public float horizontalMove;
    public float verticalMove;
    public float rotationY;
    public float playerSpeed = 3;
    private Rigidbody physicsBody;
    private float jumpForce;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        //player = GetComponent<CharacterController>();
        jumpForce = 5f;
        physicsBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");
        rotationY = Input.GetAxis("Mouse X");
        //player.Move(new Vector3(horizontalMove, 0, verticalMove) * playerSpeed * Time.deltaTime);
        transform.Translate(new Vector3 (horizontalMove,0f,verticalMove) * playerSpeed * Time.deltaTime);
        //transform.Translate(0, 0, Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime);
        //float mouseX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        transform.Rotate(new Vector3 (0f, rotationY, 0f) * rotationSpeed * Time.deltaTime);

        //salto
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("salto");
            physicsBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            
        }

    }
    
}
