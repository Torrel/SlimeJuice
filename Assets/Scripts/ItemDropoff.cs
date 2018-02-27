using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDropoff : MonoBehaviour {

	public GameObject stuff;
	public Transform Juice1;
	public float Juicelvl = 0;
	public GameObject GameOvaUI;


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
				Juicelvl += 1f;
				JuicedUp();
			}

	}


	void JuicedUp() // Moves the Juice lvl up
	{
		if(Juicelvl < 10f)
		{
		Juice1.Translate(0,0.1f,0);
		}
		
		if(Juicelvl == 10f)
		{
		GameOvaUI.SetActive(true);
		}
	}
}

