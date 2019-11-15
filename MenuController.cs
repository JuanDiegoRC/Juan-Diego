using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour 

{
	public Image fadeImage;

	public void Play()
	{
		//SceneManager.LoadScene("Game");
		StartCoroutine(LoadYourAsyncScene("Game"));
	}

	public void Salir()
	{
		SceneManager.LoadScene("Menu");
	}

	public void Opciones()
	{
		//SceneManager.LoadScene("OptionsMenu");
		StartCoroutine(LoadYourAsyncScene("OptionsMenu"));
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

}
