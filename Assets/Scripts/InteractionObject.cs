using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InteractionObject : MonoBehaviour {

	private CameraFollow PickedUp;
	private Animator anim;
	public bool Booped = false;
	public Rigidbody2D rb;
	
	public void Used()
	{
		PickedUp.enabled = !PickedUp.enabled;
		AnimationState();
	}
	// Use this for initialization
	void Start () {
		PickedUp = GetComponent<CameraFollow>();
		anim = GetComponent<Animator>();
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void AnimationState()
	{
		if (Booped == true)
		{
			anim.Play("Idle");
			Booped = false;
			rb.freezeRotation = false;
		}
		else if (Booped == false)
		{
			anim.Play("Static");
			Booped = true;
			rb.freezeRotation = true;
		}
		
	}
}
