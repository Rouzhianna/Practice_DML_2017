using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	// Use this for initialization
	//public void changeToScene (int changeTheScene) {
	//	SceneManager.LoadScene (changeTheScene);
	//}

	public void changeToScene (string sceneName) {
		Application.LoadLevel (sceneName);
	}
}
