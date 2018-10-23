using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour {

	void PlayButton()
	{
		SceneManager.LoadScene("Main");
	}

	void QuitButton()
	{
		Application.Quit();
	}
}
