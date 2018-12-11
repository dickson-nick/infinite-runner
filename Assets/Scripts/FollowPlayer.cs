using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*******************************************
 *  Script that is used to make the camera *
 *      follow the player as he moves      *
 ******************************************/
public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;

	// Use this for initialization
	void Start () {
        offset.Set(0, 8, -28);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = player.position + offset;
	}
}
