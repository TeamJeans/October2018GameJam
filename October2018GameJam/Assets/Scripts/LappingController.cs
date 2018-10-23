using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LappingController : MonoBehaviour {

	[SerializeField]
	BoxCollider2D startingLine;
	[SerializeField]
	BoxCollider2D finishLine;
	[SerializeField]
	BoxCollider2D checkPoint1;
	[SerializeField]
	BoxCollider2D checkPoint2;
	[SerializeField]
	BoxCollider2D checkPoint3;
	[SerializeField]
	BoxCollider2D playerCollider;

	[SerializeField]
	Text playerLapsText;

	[SerializeField]
	Player player;

	void Awake()
	{
		startingLine.enabled = true;
		finishLine.enabled = false;
		checkPoint1.enabled = false;
		checkPoint2.enabled = false;
		checkPoint3.enabled = false;
		playerLapsText.text = "LAP:" + player.LapNumber;
	}

	// Update is called once per frame
	void Update () {
		// Check that the player has just started the lap
		if (startingLine.IsTouching(playerCollider))
		{
			startingLine.enabled = false;
			checkPoint1.enabled = true;
		}
		else if (checkPoint1.IsTouching(playerCollider))
		{
			checkPoint1.enabled = false;
			checkPoint2.enabled = true;
		}
		else if (checkPoint2.IsTouching(playerCollider))
		{
			checkPoint2.enabled = false;
			checkPoint3.enabled = true;
		}
		else if (checkPoint3.IsTouching(playerCollider))
		{
			checkPoint3.enabled = false;
			finishLine.enabled = true;
		}

		if(finishLine.IsTouching(playerCollider))
		{
			finishLine.enabled = false;
			startingLine.enabled = true;
			player.LapNumber++;
			playerLapsText.text = "LAP:" + player.LapNumber;
		}

	}
}
