using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GearNumberGeneration : MonoBehaviour {

	[SerializeField]
	Text gearTextPlayer1;
	[SerializeField]
	Text gearTextPlayer2;

	[SerializeField]
	Text[] gearTextArray;
	[SerializeField]
	Text[] gearTextArray2;
	[SerializeField]
	int[] gearIntArray;
	public int[] GearIntArray { get { return gearIntArray; } }

	[SerializeField]
	PlayerMovementPlayer1 playerMovementPlayer1;
	[SerializeField]
	PlayerMovementPlayer2 playerMovementPlayer2;

	[SerializeField]
	Text changeGearText;

	[SerializeField]
	BoxCollider2D[] gearColliders;

	[SerializeField]
	BoxCollider2D[] gearColliders2;

	[SerializeField]
	BoxCollider2D trackerCollider;

	[SerializeField]
	BoxCollider2D trackerCollider2;

	[SerializeField]
	Player player;

	[SerializeField]
	Player player2;

	int randomGear;
	bool randomGearNumGenerated = false;
	bool playerHasReachedTarget = false;

	void Start () {
		randomGear = Random.Range(1, 7);
		randomGearNumGenerated = true;
		changeGearText.text = "CHANGE TO GEAR " + randomGear;

		List<int> ints = new List<int>();
		List<int> values = new List<int>();
		int min = 1;
		int max = 6;
		int needed = 6;

		for (int i = min; i <= max; ++i)
		{
			ints.Add(i);
		}

		for (int i = 0; i < needed; ++i)
		{
			int index = Random.Range(0, ints.Count);
			values.Add(ints[index]);
			ints.RemoveAt(index);
		}

		for (int i = 0; i < gearTextArray.Length; i++)
		{
			gearTextArray[i].text = values[i].ToString();
			gearTextArray2[i].text = gearTextArray[i].text;
			gearIntArray[i] = values[i];
		}

	}

	void Update()
	{
		gearTextPlayer1.text = "GEAR:" + player.NoOfGearsWon + "/" + player.noOfGearsToDo;
		gearTextPlayer2.text = "GEAR:" + player2.NoOfGearsWon + "/" + player2.noOfGearsToDo;

		for (int i = 0; i < gearTextArray.Length; i++)
		{
			if (trackerCollider.IsTouching(gearColliders[i]))
			{
				player.CurrentGear = gearIntArray[i];
			}

			if (trackerCollider2.IsTouching(gearColliders2[i]))
			{
				player2.CurrentGear = gearIntArray[i];
			}
		}

		if (player.CurrentGear == randomGear && player2.CurrentGear != randomGear && !playerHasReachedTarget)
		{
			playerHasReachedTarget = true;
			changeGearText.text = "PLAYER 1 GOT THERE FIRST!";
			player.NoOfGearsWon++;
			randomGearNumGenerated = false;
			playerMovementPlayer2.MovementSpeed -= 2;
			StartCoroutine(ChangeGear());
			
		}
		else if (player.CurrentGear != randomGear && player2.CurrentGear == randomGear && !playerHasReachedTarget)
		{
			playerHasReachedTarget = true;
			changeGearText.text = "PLAYER 2 GOT THERE FIRST!";
			player2.NoOfGearsWon++;
			randomGearNumGenerated = false;
			playerMovementPlayer1.MovementSpeed -= 2;
			StartCoroutine(ChangeGear());
		}
	}

	IEnumerator ChangeGear()
	{
		Debug.Log("Start of the coroutine");
		yield return new WaitForSeconds(5.0f);
		playerHasReachedTarget = false;
		Debug.Log("It works");
		if (!randomGearNumGenerated)
		{
			randomGearNumGenerated = true;
			randomGear = Random.Range(1, 7);
			changeGearText.text = "CHANGE TO GEAR " + randomGear;
		}
		playerMovementPlayer1.MovementSpeed = 10.0f;
		playerMovementPlayer2.MovementSpeed = 10.0f;
		Debug.Log("End of coroutine");
	}
}
