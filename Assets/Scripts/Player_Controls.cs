using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controls : MonoBehaviour {

	private Rigidbody rb;
	public static float jetPackFuel = 1.7f;
	public float jetPackForce = 100.0f;

	void Start(){
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Jump") ) {
			BoostUp ();
		}
	}

	void BoostUp () {
		jetPackFuel = Mathf.MoveTowards (jetPackFuel, 0, Time.fixedDeltaTime);
		rb.AddForce (Vector3.up * jetPackForce);
		
	}
}
