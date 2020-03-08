using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{

	public GameObject pauseButton;
	public GameObject pauseMenu;

	public GameObject monster;

	public BoxCollider targetRay;
    
	
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			MenuPause();
		}
    }

	public void MenuPause()
	{
		pauseButton.SetActive(false);
		pauseMenu.SetActive(true);
		monster.SendMessage("Stop");
		targetRay.enabled = false;

	}

	public void ReturnGame()
	{
		pauseButton.SetActive(true);
		pauseMenu.SetActive(false);
		targetRay.enabled = true;
	}

	public void ExitGame()
	{
		Application.Quit();

	}
}
