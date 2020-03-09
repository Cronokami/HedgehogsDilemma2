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
        apontarSeta();
    }


    void apontarSeta()
    {
        seta.transform.LookAt(objetivos[currentFase].transform);
    }
}
