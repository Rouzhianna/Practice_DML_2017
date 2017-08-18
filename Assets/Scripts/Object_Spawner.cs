using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Spawner : MonoBehaviour {

	public GameObject player;
	public GameObject[] coins;
	public GameObject enemy; 
	private float coinSpawnTimer = 2.0f;
	private float enemySpawnTimer = 4.0f;
	
	// Update is called once per frame
	void Update () {
		coinSpawnTimer -= Time.deltaTime;
		enemySpawnTimer -= Time.deltaTime;

		if (coinSpawnTimer < 0.01) {
			SpawnCoins ();
		}

		if (enemySpawnTimer < 0.01) {
			SpawnEnemy ();
		}
	}

	void SpawnCoins () {
		Instantiate (coins [(Random.Range (0, coins.Length))], new Vector3 (player.transform.position.x + 10, Random.Range (2, 8), 0), Quaternion.identity);
		coinSpawnTimer = Random.Range (1.0f, 3.0f);
	}

	void SpawnEnemy () {
		enemy.transform.localScale = new Vector3 (Random.Range (1, 5), Random.Range (1, 5), Random.Range (1, 5));
		Instantiate (enemy, new Vector3 (player.transform.position.x + 20, Random.Range (1, 9), 0), Quaternion.identity);
		enemySpawnTimer = Random.Range (1.0f, 5.0f);
	}
}
