using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrayScaleScript : MonoBehaviour {

	public Camera cam;
	public Shader sh;

	void Start() {
		cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
		cam.SetReplacementShader (sh, "Transparent");
	}

	void FixedUpdate(){
		cam.RenderWithShader (sh, null);
	}

}
