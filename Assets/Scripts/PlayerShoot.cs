using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {
	
	Transform muzzle;
	
	public float bulletspeed;
	
	public float mouseSpeed;

	void Start () {
		muzzle = GameObject.FindGameObjectWithTag("muzzle").transform;
		
	}
	
	void Update () {
		
		if(Input.GetMouseButtonDown(0))
		{
			Instantiate(Resources.Load("bullet"), muzzle.position, muzzle.rotation);
		}
			
	}
}
