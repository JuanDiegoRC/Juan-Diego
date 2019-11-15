using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour 
{
	public float speed = 40.0f;

	public string fireAxis;

	public GameObject bullet_prefab;

	public Transform bullet_spawn;
	




	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Pow
			if(Input.GetButtonDown(fireAxis))
			{
			Debug.Log("Puhao!");
			GameObject.Instantiate(bullet_prefab, bullet_spawn.position, bullet_spawn.rotation);
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
