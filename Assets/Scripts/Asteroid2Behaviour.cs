using UnityEngine;
using System.Collections;

public class Asteroid2Behaviour : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		rigidbody.AddForce(150,0,-150);

	}
	
	// Update is called once per frame
	void Update ()
				
		{
		if(transform.position.z >16)
		{
			Vector3 pos = transform.position;
				
			pos.z = -36;
			
			transform.position = pos;
		}
		if(transform.position.z < -36)
		{
			Vector3 pos = transform.position;
			
			pos.z = 16;
			
			transform.position = pos;
		}
		if(transform.position.x < -43)
		{
			Vector3 pos = transform.position;
			
			pos.x = 43;
			
			transform.position = pos;
		}
		if(transform.position.x > 43)
		{
			Vector3 pos = transform.position;
			
			pos.x = -43;
			
			transform.position = pos;
			
		}
			transform.Rotate(0,1,1);
	}
}
