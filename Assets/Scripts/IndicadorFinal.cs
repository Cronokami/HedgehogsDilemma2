using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IndicadorFinal : MonoBehaviour
{
    public int currentFase;

    public GameObject seta;

    public GameObject[] objetivos;

    private void Start()
    {
        currentFase = 0;
    }

    private void Update()
    {

        Vector3 teste = Vector3.Lerp(seta.transform.position, objetivos[currentFase].transform.position, 0.5f);


        seta.transform.LookAt(teste);
    }
}
