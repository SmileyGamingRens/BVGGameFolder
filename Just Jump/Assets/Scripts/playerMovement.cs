using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    Rigidbody rbRCop;
    [SerializeField] float movementSpeedRCop = 6f;
    [SerializeField] float jumpForceRCop = 6f;


    // Start is called before the first frame update
    void Start()
    {
        rbRCop = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rbRCop.velocity = new Vector3(horizontalInput * movementSpeedRCop, rbRCop.velocity.y, verticalInput * movementSpeedRCop);

        if (Input.GetButtonDown("Jump"))
        {
            rbRCop.velocity = new Vector3(rbRCop.velocity.x, jumpForceRCop, rbRCop.velocity.z);
        }
    }
}
