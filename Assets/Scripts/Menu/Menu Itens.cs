using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuItens: MonoBehaviour
{
    public GameObject reliquias;
    private Animator anim;
    private bool estadoMenu = false, abriuMenu = false;
    private float tempo = 0f;
    public float tempoExibicao = 5f;

    // Start is called before the first frame update
    void Start()
    {
        anim = reliquias.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab) || Input.GetKeyDown(KeyCode.Joystick1Button1))
        {
            estadoMenu = true;
        }

        if (estadoMenu)
        {
            if (!abriuMenu)
            {
                anim.SetTrigger("Abrir");
                abriuMenu = true;
            }

            //Debug.Log(tempo);
            tempo += (1 * Time.deltaTime);

            if (tempo >= tempoExibicao)
            {
                estadoMenu = false;
                abriuMenu = false;
                anim.SetTrigger("Fechar");
                tempo = 0f;
            }
        }
    }
}
