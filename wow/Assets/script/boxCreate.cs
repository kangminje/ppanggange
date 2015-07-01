using UnityEngine;
using System.Collections;

public class boxCreate : MonoBehaviour {
	private float time;
	private float x;
	private int boxKind;
	public bool isStart;
	public int score;

	// Use this for initialization
	void Start () {
		time = 0.0f;
		x = 0.0f;
		boxKind = 0;
		isStart = true;
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;

		if (isStart) {

			if (time >= 1.0f) {
				time = 0.0f;
				boxKind = Random.Range (0, 3);
		
				x = Random.Range (-5, 5);

				switch (boxKind) {
				case 0:
					GameObject box = Resources.Load ("box1") as GameObject;
				
					Instantiate (box, new Vector3 (x, 8.0f, 13.0f), transform.rotation);
					break;
				case 1:
					GameObject box2 = Resources.Load ("box2") as GameObject;
				
					Instantiate (box2, new Vector3 (x, 8.0f, 12.5f), transform.rotation);
					break;
				case 2:
					GameObject box3 = Resources.Load ("box3") as GameObject;
				
					Instantiate (box3, new Vector3 (x, 8.0f, 12.5f), transform.rotation);
					break;

				}
			
			}
		}
	
	}
}
