﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Object : MonoBehaviour {

	public int rotateSpeed;
	 //вращение монеток
	void FixedUpdate () {
		transform.Rotate (Vector3.up * rotateSpeed * Time.fixedDeltaTime);
	}

}
