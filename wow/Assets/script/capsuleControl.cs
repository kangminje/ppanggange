using UnityEngine;
using System.Collections;

public class capsuleControl : MonoBehaviour {
	public float speed;
	public bool isBullet;
	public float BulletTime;
	public int 	life;
	public int score;
	//public GameObject bullet;

	// Use this for initialization
	void Start () {
		speed = 10.0f;
		isBullet = false;
		BulletTime = 0.0f;
		life = 10;
		score = 0;

	}
	
	// Update is called once per frame
	void Update () {
		if (life == 0) {
			GameObject.Find ("Plane").GetComponent<boxCreate>().isStart = false;
			Destroy (this.gameObject);
		}
	
		transform.Translate(Vector3.right * Input.GetAxisRaw ("Horizontal") * Time.deltaTime * speed);

		if (isBullet) {
			BulletTime += Time.deltaTime;
			if(BulletTime >= 10.0f)
			{
				isBullet = false;
				BulletTime = 0.0f;
			}

			if (Input.GetKeyDown (KeyCode.Space)) {
				GameObject bullet = Resources.Load ("Bullet") as GameObject;

				Instantiate (bullet, new Vector3 (transform.position.x, transform.position.y + 1.5f, transform.position.z), transform.rotation);
			}
		}

	}
}
