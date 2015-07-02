using UnityEngine;
using System.Collections;

public class ballControl : MonoBehaviour {
	public float speed;

	//private Transform capsuleTransform;


	// Use this for initialization
	void Start () {
		speed = 10.0f;

	//	capsuleTransform = GameObject.Find ("capsule").
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.up * Time.deltaTime * speed);

		if(transform.position.y >= 8.0f)
			Destroy(this.gameObject);
	}
}
