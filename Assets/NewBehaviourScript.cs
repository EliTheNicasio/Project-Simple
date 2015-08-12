using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
		
	public Vector2 speed = new Vector2(2, 2);

	private Vector2 movement;

	// Update is called once per frame
	void Update () {
		float inputX = Input.GetAxis ("Horizontal");
		bool jump = Input.GetKeyDown(KeyCode.Space);
		float inputY;

		if (speed.x > 10) 
		{
			speed.x =  10;
		}

		if (jump) {
			inputY = 4;
		} else {
			inputY = GetComponent<Rigidbody2D> ().velocity.y;
		}

		movement = new Vector2 (
			speed.x * inputX,
			inputY);
	}

	void FixedUpdate()
	{
		GetComponent<Rigidbody2D>().velocity = movement;
	}
}
