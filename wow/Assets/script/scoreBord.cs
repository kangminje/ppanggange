using UnityEngine;
using System.Collections;

public class scoreBord : MonoBehaviour {


	void OnGUI(){
		GUI.Label (new Rect (80, 300, Screen.width, Screen.height), "Score : " + GameObject.Find ("Capsule").GetComponent<capsuleControl> ().score.ToString());
		GUI.Label (new Rect (750, 300, Screen.width, Screen.height), "Life : " + GameObject.Find ("Capsule").GetComponent<capsuleControl> ().life.ToString());


	}

}
