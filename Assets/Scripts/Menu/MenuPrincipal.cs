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

    public GameObject[] cutscene;

    public int qualImagem;


    private void Start()
    {
        qualImagem = 0;
    }

    public void StartGame()
    {
        StartCoroutine(StartGameCutscene());
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


    IEnumerator StartGameCutscene()
    {
        cutscene[qualImagem].SetActive(true);
        yield return new WaitForSeconds(1.5f);
        cutscene[qualImagem].SetActive(false);
        qualImagem++;
        cutscene[qualImagem].SetActive(true);
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(1);



    }
}
