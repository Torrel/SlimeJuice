using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float movspeed;

    public Animator anim;

    void Start () 
	{
        anim = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () 
	{
       	if(Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
		{
			transform.Translate (new Vector3(Input.GetAxisRaw("Horizontal") * movspeed * Time.deltaTime, 0, 0));
            anim.Play("WalkingS", -1);
        }
		//bool held Input.GetKey("up");
		if(Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
		{
			transform.Translate (new Vector3(0, 0, Input.GetAxisRaw("Vertical") * movspeed * Time.deltaTime));
            anim.Play("Walking", -1);

        }
	}
}
