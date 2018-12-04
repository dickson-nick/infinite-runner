using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.position = transform.position + new Vector3(0.0f, 0.0f, 1.0f);

        if (transform.position.z >= 4000) {
            transform.position = new Vector3(-16.0f, -11.6f, 48.4f);
        }
	}
}
