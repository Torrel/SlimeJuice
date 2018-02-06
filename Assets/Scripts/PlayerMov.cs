using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour {

	public int playerSpeed = 5;
	public bool facingRight= true;
	public float playerJumpPower = 50;
	public float moveX;
	public int JumpCount = 0;
	public int JumpLimit;
	public GameManager gamemanager;
	public PlayerMov player;
	public GameObject NPC;
	public GameObject Dman;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		PlayerMove ();
	}

	void PlayerMove()
	{
		//Controls here
		moveX = Input.GetAxis("Horizontal");
		if (Input.GetButtonDown ("Jump") && JumpCount < JumpLimit)
		{
			Jump();
			JumpCount += 1;
		}
		//Animation here

		//PlayerDirection
		if (moveX < 0.0f && facingRight == false){
			FlipPlayer();
		}
		else if (moveX > 0.0f && facingRight == true){
			FlipPlayer();
		}
		//Physics
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
	}

	void Jump ()
	{
		//Jumping Code
		GetComponent<Rigidbody2D>().AddForce (Vector2.up * playerJumpPower);
		//Limit Jump Count
	}
	
	void OnCollisionEnter2D()
	{
		JumpCount = 0;
	}
	void FlipPlayer()
	{
		facingRight = !facingRight;
		Vector2 localScale = gameObject.transform.localScale;
		localScale.x *= -1;
		transform.localScale = localScale;

	}

	public void StartConvo()
	{


	}



	void OnTriggerStay2D(Collider2D other)
	{
		if (other.CompareTag ("NPC"))
		{
			NPC = other.gameObject;
		}


		if (other.CompareTag ("NPC") && Input.GetButtonDown ("Use"))
		{
			gamemanager.inconvo = true;
			NPC.GetComponent<DialogueTrigger>().TriggerDialogue();
		
		}

	}
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.CompareTag ("NPC")) 
		{
			gamemanager.inconvo = false;
		}		
	}

}
