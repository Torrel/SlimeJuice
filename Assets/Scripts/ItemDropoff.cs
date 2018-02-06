using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDropoff : MonoBehaviour {

	public GameObject Items;
	public Transform Juice1;
	public float Juicelvl = 0;

	void Start()
	{
	}	

	void Update()
	{

	}

	void OnCollisionEnter2D (Collision2D col)  //Deletes items and increases juice lvl
	{
		if (col.gameObject.tag.Equals ("Items")) 
			{

				Destroy (col.gameObject);
				Juicelvl += .05f;
				Debug.Log("Item nommed");
				JuicedUp();
			}

	}


	void JuicedUp() // Moves the Juice lvl up
	{
		if(Juicelvl < 0.13f)
		{
		Juice1.Translate(0,Juicelvl,0);
		}
	}
}
