using UnityEngine;
using System.Collections;

public class PlayerPaddleController : MonoBehaviour {
	
	public float playerPaddleSpeed = 1f;

	private Vector3 playerPaddlePosition = new Vector3 (0, -4.6f, 0);
	
	void Update () 
	{
		float xPos = transform.position.x + (Input.GetAxis("Horizontal") * playerPaddleSpeed);
		playerPaddlePosition = new Vector3(Mathf.Clamp (xPos, -4.3f, 4.3f), -4.3f, 0f);
		transform.position = playerPaddlePosition;
	}
}