using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MenuScript : MonoBehaviour {

	public Canvas quitMenu; 
	public Canvas startMenu;
	//public Button startText; 
	//public Button exitText; 
	public Button pause;
	public bool paused;

	public void Start () {
		quitMenu = quitMenu.GetComponent<Canvas> ();
		startMenu = startMenu.GetComponent<Canvas> ();
	//	startText = startText.GetComponent<Button> ();
	//	exitText = exitText.GetComponent<Button> ();
		quitMenu.enabled = false;
		startMenu.enabled = true;
		//paused = !paused;

		//if (!paused) {
		//	Time.timeScale = 1;
		//	startMenu.enabled = false;
		//} else 
		
		if (!paused) {
			Time.timeScale = 1;
			startMenu.enabled = false;
		}
	}

	public void ExitPress () {     //ставит на паузу
		quitMenu.enabled = true;
		startMenu.enabled = false;

		paused = !paused;
		//if (!paused) {
		//	Time.timeScale = 1;
		//} else 
		if (paused) {
			Time.timeScale = 0;
		}
	//	startText.enabled = false;
	//	exitText.enabled = false;
	}

	public void NoPress () {         //если была пауза - снимать ее
		quitMenu.enabled = false;
		startMenu.enabled = false;

		//paused = !paused;
		if (!paused) {
			Time.timeScale = 1;
		} 
	    //else if (paused) {
		//	Time.timeScale = 0;
		//}
	//	startText.enabled = true;
	//	exitText.enabled = true;
	}

	public void PausePress () {      //ставить на паузу или возвращаться к игре
		quitMenu.enabled = false;
		startMenu.enabled = true;

		paused = !paused;
		if (!paused) {
			Time.timeScale = 1;
		} else if (paused) {
			Time.timeScale = 0;
		}
	}

	public void StartGame () {
		//Application.LoadLevel ("Main");

		paused = !paused;
		if (!paused) {
			Time.timeScale = 1;
			startMenu.enabled = false;
		} else if (paused) {
			Time.timeScale = 0;
		}
	}

	public void ExitGame () {
		Application.Quit ();
	}
}
