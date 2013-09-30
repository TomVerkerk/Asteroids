using UnityEngine;
using System.Collections;

public class BulletBehaviour : MonoBehaviour {
	
	public float speed = 4000;
	public float range = 9;
	public float time = 0;
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.left * speed * Time.deltaTime);
		time += 10 * Time.deltaTime;
		if (time > range)
		{
			Destroy(gameObject);
		}
	}
}
