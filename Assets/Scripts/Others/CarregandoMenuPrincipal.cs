using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregandoMenuPrincipal : MonoBehaviour
{
    public FinalizandoJogo finalizandoJogo;

  public void ChamarMenu()
    {
        finalizandoJogo.chamarMenu = true;
        
        //Debug.Log("Voltando Para o Menu!!");
    }
}
