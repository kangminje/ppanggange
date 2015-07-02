using UnityEngine;
using System.Collections;

public class ScoreTriger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		GameObject.Find ("ScoreBord").GetComponent<ScoreBord> ().score += 1;
		Debug.Log ("gol");

	}
}
