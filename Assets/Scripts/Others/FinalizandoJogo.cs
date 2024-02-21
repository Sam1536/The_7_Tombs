using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalizandoJogo : MonoBehaviour
{
    public bool terminouJogo = false;

    private bool playerColidindo = false;

    public bool chamarMenu = false;

    private AsyncOperation asyncLoad;

    //0 = Camera Player || 1 = Camera Creditos
    public GameObject[] cameras = new GameObject[2];
    
    //0 = Reliquias || 1 = Creditos
    public GameObject[] canvas = new GameObject[2];
    public string playerTag = "Player";

    public GameObject tonnyEstico; 
    

    public GameController gameController;

   

    // Update is called once per frame
    void Update()
    {
        if (!terminouJogo)
        {
            if (playerColidindo && gameController.totalItensColetados == 7)
            {
                cameras[0].SetActive(false);
                cameras[1].SetActive(true);

                canvas[0].SetActive(false);
                canvas[1].SetActive(true);


                GameObject.FindGameObjectWithTag("Player").SetActive(false);
                tonnyEstico.SetActive(true);
                //Debug.Log("Voce Pegou todos os artefatos!!");

                terminouJogo = true;

                StartCoroutine(CarregarMenu());

            }
            //else
            //{
            //    Debug.Log("ERRO!!");
            //}
        }
        //Debug.Log(progresso); 


    }

    IEnumerator CarregarMenu()
    {
        asyncLoad = SceneManager.LoadSceneAsync("Menu"); // carrega de forma sicronizada
        asyncLoad.allowSceneActivation = false; // não inicializa a cena quando estiver carregada 

        while (!asyncLoad.isDone)// verifica se terminou o carregamento
        {
            if (asyncLoad.progress >= .9f && chamarMenu)
            {
                asyncLoad.allowSceneActivation = true;
            }
           
           
            yield return null;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(playerTag))
        {
            playerColidindo = true;
        }
        
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(playerTag))
        {
            playerColidindo = false;
        }
    }
}
