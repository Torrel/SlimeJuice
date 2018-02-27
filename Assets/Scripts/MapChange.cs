using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.tag.Equals ("Items"))
			{
				Debug.Log("Ending2 Loading");
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);	
			}


	}
}
