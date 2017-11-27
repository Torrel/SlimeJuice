using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionObject : MonoBehaviour {

	private CameraFollow PickedUp;
	private Animator anim;
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
		}
		else if (Booped == false)
		{
			anim.Play("Static");
			Booped = true;
		}
		
	}
}
