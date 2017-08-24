using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

	//public Transform tree;
	//public int treeCount;
	public float speed = 0.5f;

	//private Vector3 mapSize = new Vector3 (50, 50, 50);

	// Use this for initialization
	void Start () {
		//generateMap ();
	}

	//void generateMap () {
	//	treeCount = 30;

	//	for (int i = 0; i < treeCount; i++) {
	//		Instantiate (tree, new Vector3
	//	}
	//}

	// Update is called once per frame
	void Update () {
		Vector2 offset = new Vector2 (Time.time * speed, 0);
		GetComponent<Renderer>().material.mainTextureOffset = offset;
	}
}
