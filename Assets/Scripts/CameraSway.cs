using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*******************************************
 *   Adds a sway effect to the camera      *
 ******************************************/
public class CameraSway : MonoBehaviour {
    public Vector3 sway;
    public Vector3 rotation;

	// Use this for initialization
	void Start () {
        sway.Set(0.1f, 0.0f, 0.0f);
        rotation.Set(0.01f, 0.0f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(sway);
        transform.Rotate(rotation);

        if (transform.position.x >= 10)
        {
            sway.Set(-0.1f, 0.0f, 0.0f);
            rotation.Set(-0.01f, 0.0f, 0.0f);
        } else if (transform.position.x <= -10)
        {
            sway.Set(0.1f, 0.0f, 0.0f);
            rotation.Set(0.01f, 0.0f, 0.0f);
        }
	}
}
