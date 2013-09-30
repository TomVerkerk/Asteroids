using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour {

	
	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.tag == "Player")
		{
			Destroy(col.gameObject);
		}
	}

}
