using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialoguePromptAppear : MonoBehaviour {
	public GameManager gameManager;

	void OnTriggerStay2D(Collider2D other)
	{
		if (other.CompareTag ("Player"))
		gameManager.DPromptTriggered();
		
	}
	void OnTriggerExit2D(Collider2D other)
	{
		gameManager.DPromptGone();
	}
}
