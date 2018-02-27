using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapChange : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name == "Sword")
			{
				Debug.Log ("Ending2 Loading");
				//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);	
			}


	}
}
