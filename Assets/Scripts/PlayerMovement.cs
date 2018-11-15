using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public bool isGrounded;

    public float forwardForce = 2000f;
    public float sidewaysForce = 10f;
    public float upwardsForce = 300f;

	// Use this for initialization
	void Start () {
        isGrounded = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            //transform.Translate(Vector3.right * sidewaysForce * Time.deltaTime);
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.A))
        {
            //transform.Translate(Vector3.left * sidewaysForce * Time.deltaTime);
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            //.Translate(Vector3.up * upwardsForce * Time.deltaTime);
            rb.AddForce(0, upwardsForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            isGrounded = false;
        }
    }
}
