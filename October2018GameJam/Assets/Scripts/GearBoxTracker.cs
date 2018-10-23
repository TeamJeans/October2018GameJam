using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearBoxTracker : MonoBehaviour {

	[SerializeField]
	Transform startNodePos;
	[SerializeField]
	GearMapNode startNode;
	[SerializeField]
	GearMapNode currentNode;

	[SerializeField]
	float movementSpeed = 10.0f;

	bool moving = false;
	bool goingUp = false;
	bool goingDown = false;
	bool goingLeft = false;
	bool goingRight = false;

	// Use this for initialization
	void Start () {
		currentNode = startNode;
		transform.position = startNodePos.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		HandleInput();
	}

	void HandleInput()
	{
		// Code for going up
		if (Input.GetKeyDown("t") && !moving)
		{
			if (currentNode.Up)
			{
				goingUp = true;
			}
		}
		if (goingUp)
		{
			moving = true;
			if (transform.position.y < currentNode.UpNodeTrasform.position.y)
			{
				transform.position = new Vector2(transform.position.x, transform.position.y + movementSpeed * Time.fixedDeltaTime);
			}
			if (transform.position.y >= currentNode.UpNodeTrasform.position.y)
			{
				transform.position = currentNode.UpNodeTrasform.position;
				currentNode = currentNode.UpNodeTrasform.gameObject.GetComponent<GearMapNode>();
				moving = false;
				goingUp = false;
			}
		}

		// Code for going down
		if (Input.GetKeyDown("g") && !moving)
		{
			if (currentNode.Down)
			{
				goingDown = true;
			}
		}
		if (goingDown)
		{
			moving = true;
			if (transform.position.y > currentNode.DownNodeTrasform.position.y)
			{
				transform.position = new Vector2(transform.position.x, transform.position.y - movementSpeed * Time.fixedDeltaTime);
			}
			if (transform.position.y <= currentNode.DownNodeTrasform.position.y)
			{
				transform.position = currentNode.DownNodeTrasform.position;
				currentNode = currentNode.DownNodeTrasform.gameObject.GetComponent<GearMapNode>();
				moving = false;
				goingDown = false;
			}
		}

		// Code for going right
		if (Input.GetKeyDown("h") && !moving)
		{
			if (currentNode.Right)
			{
				goingRight = true;
			}
		}
		if (goingRight)
		{
			moving = true;
			if (transform.position.x < currentNode.RightNodeTrasform.position.x)
			{
				transform.position = new Vector2(transform.position.x + movementSpeed * Time.fixedDeltaTime, transform.position.y);
			}
			if (transform.position.x >= currentNode.RightNodeTrasform.position.x)
			{
				transform.position = currentNode.RightNodeTrasform.position;
				currentNode = currentNode.RightNodeTrasform.gameObject.GetComponent<GearMapNode>();
				moving = false;
				goingRight = false;
			}
		}

		// Code for going left
		if (Input.GetKeyDown("f") && !moving)
		{
			if (currentNode.Left)
			{
				goingLeft = true;
			}
		}
		if (goingLeft)
		{
			moving = true;
			if (transform.position.x > currentNode.LeftNodeTrasform.position.x)
			{
				transform.position = new Vector2(transform.position.x - movementSpeed * Time.fixedDeltaTime, transform.position.y);
			}
			if (transform.position.x <= currentNode.LeftNodeTrasform.position.x)
			{
				transform.position = currentNode.LeftNodeTrasform.position;
				currentNode = currentNode.LeftNodeTrasform.gameObject.GetComponent<GearMapNode>();
				moving = false;
				goingLeft = false;
			}
		}
	}
}
