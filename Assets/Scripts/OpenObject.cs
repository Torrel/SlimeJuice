using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenObject : MonoBehaviour {

	public Rigidbody2D goodie;
	public int dug = 0;

void OnTriggerStay2D(Collider2D other)
	{
		if(Input.GetButtonDown ("Use") && dug < 3)
		{
		Rigidbody2D clone;
		clone = Instantiate(goodie, transform.position, transform.rotation) as Rigidbody2D;
		clone.velocity = transform.TransformDirection(Vector2.up * 3);
		dug += 1;
		}
	}


	// Use this for initialization
	
}
