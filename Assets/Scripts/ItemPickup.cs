using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour {
	
	public GameObject currentItem = null;
	private bool PickedUp = false;

	void Update()
	{
		if (Input.GetButtonDown ("Use") && currentItem)
		{
			currentItem.SendMessage("Used");
			PickedUp = true;
		} 

	}

	void OnTriggerStay2D(Collider2D other)
	{
		if (other.CompareTag ("Items")) 
		{
			currentItem = other.gameObject;
		}

	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.CompareTag ("Items")) 
		{
			if(other.gameObject == currentItem)
			{
				currentItem = null;
			}
		}		
	}
	/*private bool pickedup = false;
 
	// Use this for initialization
	void Start () {
		gameObject.GetComponent<CameraFollow>();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnUse ()
	{
		if (Input.GetKeyUp("Use") && pickedup == false)
			{	
			CameraFollow.enabled = true;
			pickedup = true;
			}
		else if (Input.GetButtonDown("Use") && pickedup == true)
			{
			CameraFollow.enabled = false;
			pickedup = false;
			}	
		
	} */


}
