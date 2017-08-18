using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarScript : MonoBehaviour {

	[SerializeField]
	private float fillAmount;
	[SerializeField]
	private Image content;
	private float min;
	private float time;

	// Use this for initialization
	void Start () {
		time = 0f;
		min = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (content.fillAmount > 0) {
			fillAmount = content.fillAmount;
			content.fillAmount -= 0.001f;
		}
	}

}
