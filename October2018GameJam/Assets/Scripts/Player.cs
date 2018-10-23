using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	int lapNumber = 0;
	public int LapNumber { get { return lapNumber; }set{ lapNumber = value; } }
	int noOfGearsWon = 0;
	public int NoOfGearsWon { get { return noOfGearsWon; } set { noOfGearsWon = value; } }
	[SerializeField]
	int currentGear = 0;
	public int CurrentGear { get { return currentGear; } set { currentGear = value; } }
	[SerializeField]
	Sprite[] carSprites;

	void Start()
	{
		int randomSpriteIndex = Random.Range(0, carSprites.Length);
		this.gameObject.GetComponent<SpriteRenderer>().sprite = carSprites[randomSpriteIndex];
	}
}
