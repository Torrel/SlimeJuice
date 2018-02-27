using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	
	public bool inconvo = false;
	public GameObject DialogueUI;
	public GameObject GameOver;

	public void inconvon()
	{
		inconvo = true;
	}

	public void inconvoff()
	{
		inconvo = false;
	}

	public void Update()
	{
		if (inconvo ==  true)
			{
				DialogueUI.SetActive(true);
		 	}
		else
			{
				DialogueUI.SetActive(false);
			}
	}

}
