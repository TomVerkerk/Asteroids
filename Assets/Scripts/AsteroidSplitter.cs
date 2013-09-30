using UnityEngine;
using System.Collections;

public class AsteroidSplitter : MonoBehaviour
{
	void Start () {
	
	}
	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.tag == "Player")
		{
			Destroy(col.gameObject);
		}
		if(col.gameObject.tag == "bullet")
		{
			Instantiate(Resources.Load("Asteroid1"), transform.position, transform.rotation);
			Instantiate(Resources.Load("Asteroid2"), transform.position, transform.rotation);
			Destroy(gameObject);
			}
		}
	}