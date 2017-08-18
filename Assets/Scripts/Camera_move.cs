using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_move : MonoBehaviour {

	private GameObject player;

	void Start(){
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void FixedUpdate () {
		Vector3 camPos = transform.position;
		camPos.x = player.transform.position.x + 10.0f;
		camPos.y = player.transform.position.y + 4.0f;
		transform.position = Vector3.Lerp (transform.position, camPos, 5 * Time.fixedDeltaTime);
	}
}
