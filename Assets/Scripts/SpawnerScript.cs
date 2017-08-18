using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {

	public GameObject player;
	public GameObject[] drugs;
	public GameObject enemy;
	private float drugSpawnTimer = 1.0f;
	private float enemySpawnTimer = 7.0f;

	// Update is called once per frame
	void Update () {
		drugSpawnTimer -= Time.deltaTime;
		enemySpawnTimer -= Time.deltaTime;
		if (drugSpawnTimer < 0.01) {
			SpawnDrugs ();
		}
		if (enemySpawnTimer < 0.01) {
			SpawnEnemy ();
		}
	}

	void SpawnDrugs(){
		Instantiate (drugs[(Random.Range (0, drugs.Length))], new Vector3 (player.transform.position.x + 20, Random.Range(2, 4), 0), Quaternion.identity);
		drugSpawnTimer = Random.Range (1.0f, 3.0f);
	}

	void SpawnEnemy(){
		enemy.transform.localScale = new Vector3 (Random.Range (1, 5), Random.Range (1, 5), Random.Range (1, 5));
		Instantiate (enemy, new Vector3 (player.transform.position.x + 20, Random.Range (1, 3), 0), Quaternion.identity);
		enemySpawnTimer = Random.Range (1, 3);
	}
}
