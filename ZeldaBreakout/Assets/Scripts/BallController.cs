using UnityEngine;
using System.Collections;

public class PlayerBall : MonoBehaviour {
	
	public float ballVelocity = 150f;

	public Rigidbody2D rb;
	public bool ballInPlay;
	public float ballSpeed = 1.5f;
	
	void Awake () 
	{
		rb = GetComponent<Rigidbody2D>();
	}
	
	void Update () 
	{
		if (Input.GetButtonDown("Fire1") && ballInPlay == false)
		{
			transform.parent = null;
			ballInPlay = true;
			rb.isKinematic = false;
			rb.AddForce(new Vector3(ballVelocity, ballVelocity, 0));
		}
	}
}