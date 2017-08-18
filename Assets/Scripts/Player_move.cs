using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_move : MonoBehaviour {

	public static int speed = 15;
	public int jumpAmount = 2;
	private Rigidbody rigidbody;
	public Image bar;
	private Vector3 move = Vector3.right;

	void Start(){
		rigidbody = GetComponent <Rigidbody>();
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (bar.fillAmount > 0) {
			gameObject.transform.Translate (move * speed * Time.fixedDeltaTime);
			if (Input.GetKeyDown (KeyCode.Space) & jumpAmount > 0) 
				Jump();
			if (jumpAmount < 2) {
				move.y += Physics.gravity.y * Time.deltaTime;
			}
		}
	}

	void Jump() {
		move.y = 3;
		jumpAmount--;
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Ground") {
			jumpAmount = 2;
		}
	}

	void OnTriggerEnter(Collider col){
		if(col.gameObject.CompareTag("Pickup")){
			Destroy (col.gameObject);
			bar.fillAmount += 0.1f;
		}
		if(col.gameObject.CompareTag("Enemy")){
			bar.fillAmount = 0;
		}
	}
}
