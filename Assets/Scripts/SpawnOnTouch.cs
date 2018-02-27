using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnTouch : MonoBehaviour {


	public Rigidbody2D goodie;
	public int amount = 0;

void OnTriggerStay2D(Collider2D other)
	{
		if(amount < 2)
		{
		Rigidbody2D clone;
		clone = Instantiate(goodie, transform.position, transform.rotation) as Rigidbody2D;
		clone.velocity = transform.TransformDirection(Vector2.down * 1);
		amount += 1;
		}
	}


	// Use this for initialization
	
}
