using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*******************************************
 *      Controls movement of player        *  
 ******************************************/
public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public bool isGrounded;

    private float forwardForce = 250f;
    private float sidewaysForce = 1250f;
    private float upwardsForce = 25000f;

    private string leftKeyBind;
    private string rightKeyBind;
    private string jumpKeyBind;

    public GameObject pauseMenu;

	// Use this for initialization
	void Start () {
        isGrounded = false;
        rb.AddForce(0, 0, 75.0f, ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (rb.velocity.z <= 6000.0f)
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }

        if (Input.GetKey(PlayerPrefs.GetString("RightKeyBind")))
        {
            //transform.Translate(Vector3.right * sidewaysForce * Time.deltaTime);
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.Impulse);
        }

        if (Input.GetKey(PlayerPrefs.GetString("LeftKeyBind")))
        {
            //transform.Translate(Vector3.left * sidewaysForce * Time.deltaTime);
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(PlayerPrefs.GetString("JumpKeyBind")) && isGrounded && gameObject.transform.position.y <= 3)
        {
            //transform.Translate(Vector3.up * upwardsForce * Time.deltaTime);
            rb.AddForce(0, upwardsForce * Time.deltaTime, 0, ForceMode.Impulse);
            isGrounded = false;
        }
    }
}
