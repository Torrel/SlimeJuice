using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionObject : MonoBehaviour {

	private CameraFollow PickedUp;
	private Animator anim;
	private BoxCollider2D trigger;
	public bool Booped = false;

	public void Used()
	{
		PickedUp.enabled = !PickedUp.enabled;
		AnimationState();
	}
	// Use this for initialization
	void Start () {
		PickedUp = GetComponent<CameraFollow>();
		anim = GetComponent<Animator>();
		trigger = GetComponent<BoxCollider2D>();

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
			trigger.isTrigger = true;
		}
		else if (Booped == false)
		{
			anim.Play("Static");
			Booped = true;
			trigger.isTrigger = false;
		}
		
	}
}
