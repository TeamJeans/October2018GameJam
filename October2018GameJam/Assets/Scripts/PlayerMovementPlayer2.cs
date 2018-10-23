using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementPlayer2 : MonoBehaviour
{
	[SerializeField]
	float movementSpeed = 10.0f;
	public float MovementSpeed { get { return movementSpeed; } set { movementSpeed = value; } }
	[SerializeField]
	Rigidbody2D rb2D;

	// Use this for initialization
	void Awake()
	{
		rb2D = this.gameObject.GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		//Check for inputs
		if (Input.GetKey("up"))
		{
			rb2D.AddForce(transform.up * movementSpeed);
		}
		if (Input.GetKey("down"))
		{
			rb2D.AddForce(transform.up * -movementSpeed);
		}
		if (Input.GetKey("right"))
		{
			this.gameObject.transform.Rotate(Vector3.forward * -2);
		}
		if (Input.GetKey("left"))
		{
			this.gameObject.transform.Rotate(Vector3.forward * 2);
		}
	}
}
