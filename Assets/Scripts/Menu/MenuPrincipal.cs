using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{

	public GameObject pauseButton;
	public GameObject pauseMenu;


	public void StartGame()
	{
		SceneManager.LoadScene(1);

	}

	public void Credits()
	{


	}

	public void Exit()
	{
		pauseButton.SetActive(false);
		pauseMenu.SetActive(true);
	}

	public void ReturnGame()
	{
		pauseButton.SetActive(true);
		pauseMenu.SetActive(false);
	}
		public void ExitGame()
	{
		Application.Quit();

	}
}
