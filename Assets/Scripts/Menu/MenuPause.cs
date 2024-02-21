using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;


public class MenuPause : MonoBehaviour
{
    private bool estadoPausado = false;
    public GameObject canvaMenu;
    public FinalizandoJogo finalizarJogo;



    // Update is called once per frame
    public void Update()
    {
        if(finalizarJogo.terminouJogo == false)
        {
            if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Joystick1Button7))
            {
                estadoPausado = !estadoPausado;
                canvaMenu.SetActive(estadoPausado);
                if (estadoPausado)
                {
                    Time.timeScale = 0;
                }
                else
                {
                    Time.timeScale = 1;
                }

            }
        }
    }

    public void RetornaGame()
    {
        estadoPausado = false;  
        canvaMenu.SetActive(estadoPausado);
      //  Debug.Log("MENU OFF " + estadoPausado);
    }

    public void SairDOJogo()
    {
        Application.Quit();
        //Debug.Log("SAIU DO JOGO " + estadoPausado);
    }
}
