using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Gamemanager : MonoBehaviour 
{
	public static Gamemanager instance;
  
   public GameObject image;
   public GameObject image2;
   public GameObject image3;
   public GameObject image4;
   public Coche [] coches;
   public GameObject image5;
   public GameObject image6;
   public GameObject image7;
   public GameObject image8;

   public Meta Meta;

   public Image [] countDownImages;
   float waitTime = 1.0f;
   public enum VictoryType
   {
	   goal,
	   death
   }

   void Awake()
	{
		if(instance == null)
			instance = this;
		else if(instance != this)
			Destroy(this.gameObject);

		DontDestroyOnLoad(this.gameObject);
	}

   void Start()
   { 
	    

	   	for(int i=0; i<coches.Length; i++)
		{
			coches[i].id = i;
		}
		image5.SetActive(false);
		image6.SetActive(false);
		image7.SetActive(false);
		image8.SetActive(false);
    	
			StartCoroutine(Fade());
			for(int i=0; i<coches.Length; i++)
			{
				coches[i].StopCar();
			}
   }
  

	public void EndGame(int cochesId, VictoryType type)
	{
		if(type == VictoryType.death)
		{
			if (cochesId == 0)
			{
			image2.SetActive(true);
			image4.SetActive(true); 
			}
			if (cochesId == 1)
			{
			image.SetActive(true);
			image3.SetActive(true); 
			}
		
		}
		else if (type == VictoryType.goal)
		{
          if (cochesId == 0)
			{
			image.SetActive(true);
			image3.SetActive(true); 
			}
			if (cochesId == 1)
			{
			image2.SetActive(true);
			image4.SetActive(true); 
			}
		}
		if(type == VictoryType.death)	
		{
			for(int i=0; i<coches.Length; i++)
			{
				coches[i].StopCar();
			}
		}
		Debug.Log("PARAR");
		if(type == VictoryType.goal)	
		{
			for(int i=0; i<coches.Length; i++)
			{
				coches[i].StopCar();
			}
		}
	}
    IEnumerator Fade()
	{
		countDownImages[0].gameObject.SetActive(true);

		for(int i = 0; i < 4; i++)
		{
			countDownImages[i].gameObject.SetActive(true);
			
			yield return new WaitForSeconds(waitTime);

			countDownImages[i].gameObject.SetActive(false);
		}
		countDownImages[countDownImages.Length-1].gameObject.SetActive(false);

		for(int i=0; i<coches.Length; i++)
		{
			coches[i].StartCar();
		}

		yield return null;
	}
}
