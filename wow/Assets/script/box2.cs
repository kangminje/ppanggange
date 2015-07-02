using UnityEngine;
using System.Collections;

public class box2 : MonoBehaviour {
	private float speed;

	// Use this for initialization
	void Start () {
		speed = 10.0f;


	}
	
	void FixedUpdate () {
		
	}

	void Update(){
		transform.Translate (new Vector3(0.0f,0.0f,-1.0f) * Time.deltaTime * speed);

		if (transform.position.y <= -8.0f)
			Destroy (this.gameObject);

	}
	
	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "player") {
			Destroy(this.gameObject);
			GameObject.Find ("Capsule").GetComponent<capsuleControl> ().isBullet = true;
			GameObject.Find ("Capsule").GetComponent<capsuleControl> ().score += 50;

		}
		
		if (other.gameObject.tag == "bullet") {
			Destroy(this.gameObject);
			Destroy(other.gameObject);
			GameObject.Find ("Capsule").GetComponent<capsuleControl> ().score += 50;
		}
	}
}
