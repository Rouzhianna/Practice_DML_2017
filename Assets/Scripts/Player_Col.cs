using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Col : MonoBehaviour {
	public Image im;

	void OnTriggerEnter (Collider trig) {
		if (trig.gameObject.tag == "Coin") {
			Destroy (trig.gameObject);
			im.fillAmount += 0.05f;
		}

		if (trig.gameObject.tag == "Enemy") {
			im.fillAmount -= 0.01f;
		}
	}

	//void OnCollisionEnter (Collision col) {
	//	if (col.gameObject.tag == "Enemy") {
	//		im.fillAmount -= 0.01f;
	//	}
	//}

	void PlayerDies () {
		if (im.fillAmount <= 0.1f) {
			Application.LoadLevel ("Main");
		}
	}
}
