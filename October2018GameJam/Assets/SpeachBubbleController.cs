using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpeachBubbleController : MonoBehaviour {

	[SerializeField]
	GameObject player1Bubble;
	[SerializeField]
	GameObject[] playerBubbleText;

	[SerializeField]
	GameObject player2Bubble;

	[SerializeField]
	GameObject firstBubble;
	[SerializeField]
	GameObject firstBubbleText;

	[SerializeField]
	int coversationLength;
	int counter = 0;

	void Start()
	{
		firstBubble.SetActive(true);
		firstBubbleText.SetActive(true);
		player1Bubble.SetActive(false);
		for (int i = 0; i < playerBubbleText.Length; i++)
		{
			playerBubbleText[i].SetActive(false);
		}
		player2Bubble.SetActive(false);
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{

			if (firstBubble.activeSelf)
			{
				player1Bubble.SetActive(true);
				playerBubbleText[counter].SetActive(true);
				firstBubble.SetActive(false);
				firstBubbleText.SetActive(false);
			}
		}
		if (counter == coversationLength)
		{
			SceneManager.LoadScene("Main");
		}
		else
		{
			if (Input.GetMouseButtonDown(0) && !firstBubble.activeSelf)
			{
				if (player1Bubble.activeSelf)
				{
					player1Bubble.SetActive(false);
					for (int i = 0; i < playerBubbleText.Length; i++)
					{
						if (playerBubbleText[i] != playerBubbleText[counter])
						{
							playerBubbleText[i].SetActive(false);
						}
					}
					player2Bubble.SetActive(true);
					playerBubbleText[counter].SetActive(true);
				}
				else if (player2Bubble.activeSelf)
				{
					player2Bubble.SetActive(false);
					for (int i = 0; i < playerBubbleText.Length; i++)
					{
						if (playerBubbleText[i] != playerBubbleText[counter])
						{
							playerBubbleText[i].SetActive(false);
						}
					}
					player1Bubble.SetActive(true);
					playerBubbleText[counter].SetActive(true);
				}
				counter++;
			}
		}
	}
}
