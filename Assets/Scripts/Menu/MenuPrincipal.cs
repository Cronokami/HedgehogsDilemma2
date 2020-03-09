using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{

    public GameObject pauseButton;
    public GameObject pauseMenu;

    public GameObject help;
    public GameObject buttonsLayout;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void HelpButton()
    {
        help.SetActive(true);
        buttonsLayout.SetActive(false);
    }

    public void BackButton()
    {
        help.SetActive(false);
        buttonsLayout.SetActive(true);
    }

    public void Credits()
    {
        SceneManager.LoadScene("Creditos");

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
