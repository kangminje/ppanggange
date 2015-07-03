using UnityEngine;
using System.Collections;

public class joint : MonoBehaviour {

	private HingeJoint hinge;
	private JointMotor moter;



	// Use this for initialization
	void Start () {
		hinge = GetComponent<HingeJoint> ();
		moter = new JointMotor ();
		hinge.useMotor = true;
		moter.force = 100000.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.M)) {
			moter.targetVelocity = 100000.0f;

		
		}

		if (Input.GetKeyUp (KeyCode.M)) {
			moter.targetVelocity = -100000.0f;
		
			
		}


		hinge.motor = moter;
	}
}
