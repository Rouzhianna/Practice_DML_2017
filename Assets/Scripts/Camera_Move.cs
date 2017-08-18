using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Move : MonoBehaviour {

	private GameObject player;
	//public float cameraSpeed = 5.0f;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 camPos = transform.position;
		camPos.x = player.transform.position.x - -6.0f;
		transform.position = Vector3.Lerp (transform.position, camPos, 3 * Time.fixedDeltaTime);

		camPos.y = player.transform.position.y + 2;
		transform.position = Vector3.Lerp (transform.position, camPos, 7.0f * Time.fixedDeltaTime);
	}
}

