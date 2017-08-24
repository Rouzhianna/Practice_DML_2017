using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Spawner : MonoBehaviour {

	public GameObject player;
	public GameObject[] syringe;
	public GameObject enemy; 
	private float syringeSpawnTimer = 2.0f;
	private float enemySpawnTimer = 4.0f;

	// Update is called once per frame
	void Update () {
		syringeSpawnTimer -= Time.deltaTime;
		enemySpawnTimer -= Time.deltaTime;

		if (syringeSpawnTimer < 0.01) {
			SpawnSyringe ();
		}

		if (enemySpawnTimer < 0.01) {
			SpawnEnemy ();
		}
			
	}

	void SpawnSyringe () {
		Instantiate (syringe [(Random.Range (0, syringe.Length))], new Vector3 (player.transform.position.x + 10, Random.Range (2, 8), 0), Quaternion.identity);
		syringeSpawnTimer = Random.Range (1.0f, 3.0f);
	}

	void SpawnEnemy () {
		enemy.transform.localScale = new Vector3 (Random.Range (1, 5), Random.Range (1, 5), Random.Range (1, 5));
		Instantiate (enemy, new Vector3 (player.transform.position.x + 20, Random.Range (1, 9), 0), Quaternion.identity);
		enemySpawnTimer = Random.Range (4.0f, 6.0f);
	}


		
}
