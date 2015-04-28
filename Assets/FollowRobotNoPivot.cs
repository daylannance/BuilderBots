using UnityEngine;
using System.Collections;

public class FollowRobotNoPivot : MonoBehaviour {
	public Transform target;
	public Vector3 offset;
	bool isOffsetInitialized = false;
	// Use this for initialization
	void Awake () {
		offset = target.position - transform.position;
		isOffsetInitialized = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(isOffsetInitialized)
		{
			transform.position = target.position - offset;
		}
	}
}
