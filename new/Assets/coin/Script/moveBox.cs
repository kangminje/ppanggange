using UnityEngine;
using System.Collections;

public class moveBox : MonoBehaviour {
	public float speed;
	private bool front;

	// Use this for initialization
	void Start () {
		speed = 1.0f;
		front = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (front) {
			if (transform.position.z <= -3.0f)
				transform.Translate (new Vector3 (0, 0, 1) * Time.deltaTime * speed);
			else
				front = false;
		} else {

			if (transform.position.z >= -3.5f)
				transform.Translate (new Vector3 (0, 0, -1) * Time.deltaTime * speed);
			else
				front = true;
		}
	}
}
