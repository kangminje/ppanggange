using UnityEngine;
using System.Collections;

public class coinDelete : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y <= -5.0f)
			Destroy (this.gameObject);
	
	}
}
