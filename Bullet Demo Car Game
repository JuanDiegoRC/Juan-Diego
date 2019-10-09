using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour 
{
	public float time = 2.0f;
	public float speed = 40.0f;	

	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
		
		time -= Time.deltaTime;
		if(time <= 0)
		{
			Destroy(gameObject);
		}
		
	}

	void OnCollisionEnter(Collision collision)
		{
			Debug.Log("Die");
			if(collision.gameObject.tag == "Qué bolas!")
			{
				
				Destroy(collision.gameObject);
				
			}
			
		}
}
