using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneFaceController : MonoBehaviour {

	[SerializeField]
	int[] differentFaces;

	[SerializeField]
	Sprite[] gingerBaldManSprites;
	[SerializeField]
	Sprite[] grannySprites;
	[SerializeField]
	Sprite[] toothPasteManSprites;
	[SerializeField]
	Sprite[] mohawkManSprites;

	[SerializeField]
	Sprite[] currentSpriteArrayPlayer1;
	[SerializeField]
	Sprite[] currentSpriteArrayPlayer2;

	[SerializeField]
	SpriteRenderer player1Face;
	[SerializeField]
	SpriteRenderer player2Face;

	int randomVal = StaticVariableHolder.randomFaceValue;
	int randomVal2 = StaticVariableHolder.randomFaceValue2;

	void Awake()
	{
		randomVal = StaticVariableHolder.randomFaceValue;
		randomVal2 = StaticVariableHolder.randomFaceValue2;
	}

	// Use this for initialization
	void Start () {
		if (randomVal == -1)
		{
			randomVal = Random.Range(0,differentFaces.Length);
			StaticVariableHolder.randomFaceValue = randomVal;
		}
		switch (differentFaces[randomVal])
		{
			case 0:	currentSpriteArrayPlayer1 = gingerBaldManSprites; break;
			case 1: currentSpriteArrayPlayer1 = grannySprites; break;
			case 2: currentSpriteArrayPlayer1 = toothPasteManSprites; break;
			case 3: currentSpriteArrayPlayer1 = mohawkManSprites; break;
			default:break;
		}

		
		if (randomVal2 == -1)
		{
			randomVal2 = Random.Range(0, differentFaces.Length);
			StaticVariableHolder.randomFaceValue2 = randomVal2;
			while (randomVal2 == randomVal)
			{
				randomVal2 = Random.Range(0, differentFaces.Length);
				StaticVariableHolder.randomFaceValue2 = randomVal2;
			}
		}

		switch (differentFaces[randomVal2])
		{
			case 0: currentSpriteArrayPlayer2 = gingerBaldManSprites; break;
			case 1: currentSpriteArrayPlayer2 = grannySprites; break;
			case 2: currentSpriteArrayPlayer2 = toothPasteManSprites; break;
			case 3: currentSpriteArrayPlayer2 = mohawkManSprites; break;
			default: break;
		}

		int randomFaceVal = Random.Range(0, currentSpriteArrayPlayer1.Length);
		player1Face.sprite = currentSpriteArrayPlayer1[randomFaceVal];

		int randomFaceVal2 = Random.Range(0, currentSpriteArrayPlayer2.Length);
		player2Face.sprite = currentSpriteArrayPlayer2[randomFaceVal2];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
