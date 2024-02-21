using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuPrincipal : MonoBehaviour
{

    public Text text;

   public void CarregarJogo()
   {
      //  Debug.Log("Entrando!!");
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
        text.text = "Iniciando....";

        //bntIniciarJogo.enabled = false;
   }

    public void SairJogo()
    {
        Application.Quit();
       // Debug.Log("Saiu!!");
    }


}
