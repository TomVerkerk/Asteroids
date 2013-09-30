using UnityEngine;
using System.Collections;

public class Movementscript : MonoBehaviour {
	
	public float speed;
	public float mouseSpeed;
	
	// Use this for initialization
	void Start ()
		{
		
		}
	
	// Update is called once per frame
	void Update () 
	{
		if(transform.position.z >9)
		{
			Vector3 pos = transform.position;
				
			pos.z = -29;
			
			transform.position = pos;
		}
		if(transform.position.z < -29)
		{
			Vector3 pos = transform.position;
			
			pos.z = 9;
			
			transform.position = pos;
		}
		if(transform.position.x < -38)
		{
			Vector3 pos = transform.position;
			
			pos.x = 37;
			
			transform.position = pos;
		}
		if(transform.position.x > 37)
		{
			Vector3 pos = transform.position;
			
			pos.x = -38;
			
			transform.position = pos;
		}
	}
	
	void FixedUpdate(){
		
		float moveHorizontal = Input.GetAxis("Mouse X");
		
		Vector3 movement = new Vector3(0.0f,0.0f,moveHorizontal)*mouseSpeed*Time.deltaTime;

		transform.Rotate(movement);
		
		Vector3 direction = new Vector3(0.0f,90f,0.0f);
			

		if(Input.GetKey(KeyCode.W))
		{rigidbody.AddRelativeForce(direction * speed * Time.deltaTime);}
		}
	

}













		
//	}
//	void OnTriggerEnter(Collider col)
//	 {
 //		 if (col.gameObject.tag == "Pickup")
 //			 {
  //			 Destroy(col.gameObject);			
//			count = count+1;			
 //  			 }
//  	 }
//	
//	void OnGUI()
//	{
//		GUI.Box(new Rect(20, 20, 100, 20), "Score : " + count.ToString());
//		
//		if(count == objects)
//		{	
//			winText.text = "You Win!";
//			speed = 0;
//		}
//	}
//	void Death ()
//	{
//		GameObject Player = new GameObject.FindGameObjectWithTag("Player");
///		
//	 if (GameObject.Player.transform.position.y <= 100)
///		{
//		Destroy(Player);
//		}
//	}
///
//}