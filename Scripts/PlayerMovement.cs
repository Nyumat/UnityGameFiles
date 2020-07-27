using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   // reference to the Rigidbody component rb
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float jumpForce = 20f;

    // FixedUpdate over Regular Update because
    // we are using it to mess with physics.
    void FixedUpdate()
    {
        //Add a foward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
          rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
          rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);

        if (Input.GetKey (KeyCode.Space))
        {
          rb.AddForce(Vector3.up * jumpForce);
        }





        }
    }
}
