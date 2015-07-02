using UnityEngine;
using System.Collections;

public class coinManagerCol : MonoBehaviour {
	public int autoCoinCount;


	// Use this for initialization
	void Start () {
		AutoGeneration ();
		autoCoinCount = 0;

		this.StartCoroutine ("AutoGeneration");
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject coin = Resources.Load ("coin") as GameObject;

		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hitObj;
			if(	Physics.Raycast(ray,out hitObj)){
				Instantiate (coin,new Vector3(hitObj.point.x,1.0f,hitObj.point.z)
				             ,Quaternion.identity);
			}
		}
	}

	IEnumerator AutoGeneration(){

		GameObject coin = Resources.Load ("coin") as GameObject;
		for (int i =0; i < autoCoinCount; ++i) {

			yield return new WaitForSeconds (0.2f);		
			Instantiate (coin, new Vector3 (0f, 5f, -4.0f), Random.rotation);
		}
	
	}
}
