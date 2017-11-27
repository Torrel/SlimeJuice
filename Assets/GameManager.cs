using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject DialoguePrompt;

	public void DPromptTriggered()
	{
		DialoguePrompt.SetActive(true);
	}
	
	public void DPromptGone()
	{
		DialoguePrompt.SetActive(false);
	}
}
