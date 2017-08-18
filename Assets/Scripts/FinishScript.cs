using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishScript : MonoBehaviour {

	// codes: 0 - time, 1 - enemy
	public Image time;
	public GameObject fin;

	void FixedUpdate () {
		if (time.fillAmount <= 0) {
			FinishGame (0);
			if (Input.GetButtonDown("Jump")){
				Application.LoadLevel(Application.loadedLevel);
			}
		}
	}

	void FinishGame(int code){
		fin.SetActive (true);
		time.fillAmount = 0;
		gameObject.GetComponent<SpawnerScript> ().enabled = false;
	}
}
