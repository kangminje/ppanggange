using UnityEngine;
using System.Collections;

public class SkyScript : MonoBehaviour {

	[SerializeField]
	private float speed = 0.5f;
	float offSet;

	GameObject Sky1;

	GameObject Sky2;



	// Use this for initialization
	void Start () {
		Sky1 = GameObject.FindWithTag ("Sky1");
		Sky2 = GameObject.FindWithTag ("Sky2");
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Translate (Vector3.left * speed);


		//if (Sky2.transform.position.x  < -14.5f) {
//Sky2.transform.Translate(27,0,0);
	//	}


		if (transform.position.x  < -14.5f) {
			transform.Translate(29,0,0);
		}
	}
}
