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
				Juicelvl += 1;
				Debug.Log("Item nommed");
				JuicedUp();
			}

	}


	void JuicedUp()
	{
		if(Juicelvl < 11)
		{
		Juice1.Translate(0,0.1f,0);
		}
	}
}
