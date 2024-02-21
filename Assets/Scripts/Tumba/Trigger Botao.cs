using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBotao : MonoBehaviour
{

    private bool playerColider = false, pressed = false;
    public string playerTag = "Player";
    public GameObject botao;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Joystick1Button1))
        {
            if (!pressed && playerColider)
            {
                pressed = true;
                Destroy(this.gameObject);

                //chama o scripts portao
                botao.GetComponent<Botao>().abrirPorta = true;
            }

           // Debug.Log("abriu!!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            playerColider = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            playerColider = false;
        }
    }
}
