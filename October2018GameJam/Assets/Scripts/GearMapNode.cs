using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearMapNode : MonoBehaviour {

	[SerializeField]
	bool up;
	public bool Up { get { return up; } }
	[SerializeField]
	Transform upNodeTransform;
	public Transform UpNodeTrasform { get { return upNodeTransform; } }
	[SerializeField]
	bool down;
	public bool Down { get { return down; } }
	[SerializeField]
	Transform downNodeTransform;
	public Transform DownNodeTrasform { get { return downNodeTransform; } }
	[SerializeField]
	bool right;
	public bool Right { get { return right; } }
	[SerializeField]
	Transform rightNodeTransform;
	public Transform RightNodeTrasform { get { return rightNodeTransform; } }
	[SerializeField]
	bool left;
	public bool Left { get { return left; } }
	[SerializeField]
	Transform leftNodeTransform;
	public Transform LeftNodeTrasform { get { return leftNodeTransform; } }
}
