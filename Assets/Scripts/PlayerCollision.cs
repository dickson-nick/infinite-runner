using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*******************************************
 *      Dictates behavior when player      *
 *         collides with an obejct         *
 ******************************************/
public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            SceneManager.LoadScene("MainMenu");
        }

        if (collision.collider.name == "Ground")
        {
            movement.isGrounded = true;
        }
    }
}
