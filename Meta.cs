using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meta : MonoBehaviour
{ 
	private Gamemanager gameManager;
	void Start ()
	{
		gameManager = Gamemanager.instance;
		
	}


	// Update is called once per frame
	void Update () 
	{
		
	}
	void OnCollisionEnter(Collision collision)
	{
		Debug.Log("Ganador");
		if(collision.gameObject.tag == "Goal")
		{
		gameManager.EndGame(collision.gameObject.GetComponent<Coche>().id, Gamemanager.VictoryType.goal);
		}
		
	
	}		

		
}
