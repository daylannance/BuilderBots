using UnityEngine;
using System.Collections;

public class MotorControl : MonoBehaviour {
	
	public float force;
	public float targetSpeed;
	HingeJoint joint;
	// Use this for initialization
	void Start () {
		joint = GetComponent<HingeJoint>();
	}
	
	// Update is called once per frame
	void Update () {
		JointMotor motor = new JointMotor();
		joint.useMotor = true;
		if(Input.GetKey (KeyCode.C))
		{
			motor.force = force;
			motor.targetVelocity = targetSpeed;
		}
		else if(Input.GetKey (KeyCode.O))
		{
			motor.force = -force;
			motor.targetVelocity = -targetSpeed;
		}
		else
		{
			motor.force = 0;
			motor.targetVelocity=0;
			motor.freeSpin = false;
		}
		joint.motor = motor;
	}
}
