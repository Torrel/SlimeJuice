using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDropoff : MonoBehaviour {

	public GameObject Items;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTrigger2D (Collider2D other)
	{
		if (other.CompareTag ("Items"))
		{
		Debug.Log ("This is working fine");


		}
	}
}
