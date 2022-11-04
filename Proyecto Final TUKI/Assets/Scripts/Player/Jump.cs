using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody physicsBody;
    private float jumpForce = 5f;
    public LayerMask mask;
    public bool canJump;
    public GameObject piesPlayer;
    // Start is called before the first frame update
    void Start()
    {
        physicsBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckGround();

        //salto
        if (Input.GetKeyDown(KeyCode.Space) && canJump == true)//&& isJumping == false)
        {
            jump();
            //jumpsCant += 1;
            //isJumping = true;
            //Invoke("PararSalto", (float)1.10);
        }
    }

    private void CheckGround()
    {
        RaycastHit hitInfo = new RaycastHit();
        Debug.DrawRay(piesPlayer.transform.position, Vector3.down * 0.6f, Color.red);
        if (Physics.Raycast(piesPlayer.transform.position, Vector3.down, out hitInfo, 0.6f, mask))
        {
            canJump = true;
        }
        else
        {
            canJump = false;
        }
        //isJumping = false;
        //jumpsCant = 0;
    }
    private void jump()
    {
        Debug.Log("salto");
        physicsBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
