using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnMenu : MonoBehaviour
{
    void Start()
    {
		StartCoroutine("RetornaMenu");
    }

	public IEnumerator RetornaMenu()
	{
		yield return new WaitForSeconds(5);
		SceneManager.LoadScene(0);
	}

}
