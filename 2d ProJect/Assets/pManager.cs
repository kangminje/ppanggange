using UnityEngine;
using System.Collections;

public class pManager : MonoBehaviour {

	public GameObject[] Blocks;
	public GameObject AZone;

	public GameObject BZone;

	[SerializeField]
	private float speed = 5f;


	// Use this for initialization
	void Start () {
		AZone = Instantiate (AZone, Vector3.right * -4.42f, Quaternion.identity) as GameObject;
		BZone = Instantiate (BZone, Vector3.right * (-4.42f + 30f), Quaternion.identity) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		AZone.transform.Translate (Vector3.left * speed * Time.deltaTime);
		BZone.transform.Translate (Vector3.left * speed * Time.deltaTime);

		if(BZone.transform.position.x <= -4.42f)
		{
			Destroy(AZone);
			AZone = BZone;

			Make();
		}
	}


	void Make()
	{
		int rIndex = Random.Range (0, Blocks.Length);
		BZone = Instantiate (Blocks [rIndex], new Vector3 (-4.42f + 30.0f, 0f, 0f), Quaternion.identity) as GameObject;

	}
}
