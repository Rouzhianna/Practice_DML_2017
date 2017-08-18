using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlickeringL : MonoBehaviour {

	public Image im;
	Light testLight;

	void Start () {
		testLight = GetComponent<Light>();
	}

	void Update () {
		if (im.fillAmount <= 0.33f) {
			StartCoroutine (Flashing ());
		}	
	}

	IEnumerator Flashing () {
		while (true) {
			yield return new WaitForSeconds (1.0f); 
			testLight.enabled = ! testLight.enabled;
		}
	}
}
