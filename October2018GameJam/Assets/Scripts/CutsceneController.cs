﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneController : MonoBehaviour {

	public void GoToMainScene()
	{
		SceneManager.LoadScene("Main");
	}
}
