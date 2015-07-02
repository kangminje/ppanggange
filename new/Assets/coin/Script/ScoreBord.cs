using UnityEngine;
using System.Collections;

public class ScoreBord : MonoBehaviour {
	public int score;


	// Use this for initialization
	void Start () {
		score = 0;
	}
	
	void OnGUI(){
		GUI.Label (new Rect (80, 300, Screen.width, Screen.height), 
		           "Score : " + score.ToString());
		       
	}
}
