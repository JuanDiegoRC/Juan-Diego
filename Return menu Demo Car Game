using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Returntomenu : MonoBehaviour 
{
	public Slider VolumeSlider;

	public Image fadeImage;

	public void Volver()
	{
		//SceneManager.LoadScene("Menu");
		StartCoroutine(LoadYourAsyncScene("Menu"));
	}

	

	IEnumerator LoadYourAsyncScene(string sceneName)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);
		asyncLoad.allowSceneActivation = false;

      

		float fadeIntensity = 0;

		Color col;

		while(fadeIntensity < 1)
		{
			fadeIntensity += 0.02f;

			col = fadeImage.color;
			col.a = fadeIntensity;

			fadeImage.color = col;

			yield return null;
		}

		col = fadeImage.color;
		col.a = fadeIntensity;

		fadeImage.color = col;

		asyncLoad.allowSceneActivation = true;
	}
	 public void AdjustVolume () 
	{
     	AudioListener.volume = VolumeSlider.value;
 	}
	
}
