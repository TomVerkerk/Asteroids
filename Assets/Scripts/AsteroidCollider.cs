using UnityEngine;
using System.Collections;

public class AsteroidCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.tag == "Player")
		{
			Destroy(col.gameObject);
		}
		if(col.gameObject.tag == "bullet")
		{
			Destroy(gameObject);
			Destroy(col.gameObject);
		}
	}
}