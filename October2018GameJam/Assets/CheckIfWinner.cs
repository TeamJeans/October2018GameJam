using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckIfWinner : MonoBehaviour {

	[SerializeField]
	Player player1;
	[SerializeField]
	Player player2;

	[SerializeField]
	Text winningText;

	bool gameFinished = false;

	private void Start()
	{
		winningText.enabled = false;
	}

	// Update is called once per frame
	void Update () {
		if (player1.LapNumber >= player1.noOfLapsToDo && player1.NoOfGearsWon >= player1.noOfGearsToDo && !gameFinished)
		{
			winningText.enabled = true;
			winningText.text = "RED WINS!";
			winningText.color = Color.red;
			gameFinished = true;
		}
		else if (player2.LapNumber >= player2.noOfLapsToDo && player2.NoOfGearsWon >= player2.noOfGearsToDo && !gameFinished)
		{
			winningText.enabled = true;
			winningText.text = "BLUE WINS!";
			winningText.color = Color.blue;
			gameFinished = true;
		}
	}
}
