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
	private float max;

	// Use this for initialization
	void Start () {
		min = 0.0f;
		max = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
		content.fillAmount -= 0.001f;
	}

	void HandleBar () {
		content.fillAmount = fillAmount;
	}
}
