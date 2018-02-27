using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialoguePromptAppear : MonoBehaviour {
	public GameObject DialoguePrompt;

	void OnTriggerStay2D(Collider2D other)
	{
		if (other.CompareTag ("Player"))
		DialoguePrompt.SetActive(true);
		
	}
	void OnTriggerExit2D(Collider2D other)
	{
		DialoguePrompt.SetActive(false);
	}


}
