using UnityEngine;
using System.Collections;

public class TorqueBody : MonoBehaviour {
	public float turningTorque;
	public ForceMode turningForceMode;
	public float movingForce;
	public ForceMode movingForceMode;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			GetComponent<Rigidbody>().AddTorque(0, turningTorque,0,turningForceMode);
		}
		if(Input.GetKey (KeyCode.RightArrow))
		{
			GetComponent<Rigidbody>().AddTorque(0, -turningTorque,0,turningForceMode);
		}
		if(Input.GetKey(KeyCode.UpArrow))
		{
			GetComponent<Rigidbody>().AddForce(transform.up * movingForce,movingForceMode);
		}
		if(Input.GetKey(KeyCode.DownArrow))
		{
			GetComponent<Rigidbody>().AddForce(transform.up * -movingForce,movingForceMode);
		}
	}
}
