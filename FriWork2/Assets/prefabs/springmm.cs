using UnityEngine;
using System.Collections;

public class springmm : MonoBehaviour {
	private Rigidbody springBody;


	// Use this for initialization
	void Start () {
		springBody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			springBody.AddForce(new Vector3(0.0f,102.0f,0.0f),ForceMode.Impulse);
		}
	
	}
}
