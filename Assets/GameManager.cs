using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject DialoguePrompt;
	public bool inconvo = false;
	public GameObject DialogueUI;


	public void DPromptTriggered()
	{
		DialoguePrompt.SetActive(true);
	}
	
	public void DPromptGone()
	{
		DialoguePrompt.SetActive(false);
	}

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
