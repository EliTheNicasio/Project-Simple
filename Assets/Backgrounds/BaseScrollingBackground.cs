using UnityEngine;
using System.Collections;

public class BaseScrollingBackground : MonoBehaviour {
	Vector2 test = new Vector2 (0,0);
	
	
	// Update is called once per frame
	void Update () {
		if(Time.time > 5)
		{
		test.x = transform.position.x - .0001f;
		} 
		else {
			test.x = transform.position.x;
		}
		print (transform.position);
		print (Time.time);
	}
	
	void FixedUpdate() {
		transform.position = new Vector3(test.x, transform.position.y, transform.position.z);
	}
}