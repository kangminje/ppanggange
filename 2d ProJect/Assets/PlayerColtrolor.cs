using UnityEngine;
using System.Collections;

public class PlayerColtrolor : MonoBehaviour {

	public enum PLAYERSTATE
	{
		RUN,
		JUMP,
		SECONDJUMP,
		DIE
	}

	private float jumpPower = 200f;
	private PLAYERSTATE state = PLAYERSTATE.RUN;

	public void SetState(PLAYERSTATE st){
		state = st;
		switch (state) {
		case PLAYERSTATE.RUN:
			anim.SetBool("Jump",false);
			break;
		case PLAYERSTATE.JUMP:
			anim.SetBool("Jump",true);
			rBody2D.AddForce(Vector2.up * jumpPower);
			break;
		case PLAYERSTATE.SECONDJUMP:
			anim.SetBool("SJump",true);
			rBody2D.AddForce(Vector2.up * jumpPower);
			rBody2D.velocity = Vector2.zero;
			break;
		case PLAYERSTATE.DIE:
			rBody2D.isKinematic = true;
			break;
		}
	}

	private Animator anim;
	private Rigidbody2D rBody2D;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		rBody2D = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			if(state == PLAYERSTATE.RUN){
				this.SetState(PLAYERSTATE.JUMP);
			}else if(state == PLAYERSTATE.JUMP){
				this.SetState(PLAYERSTATE.SECONDJUMP);
			}
		}
	}


	void OnCollisionEnter2D(Collision2D collision)
	{
		if(state != PLAYERSTATE.RUN)
			this.SetState (PLAYERSTATE.RUN);
	}
}
