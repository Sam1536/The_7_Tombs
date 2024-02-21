using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botao : MonoBehaviour
{
    public bool abrirPorta = false;
    public GameObject help;
    public GameObject portao;
    private AudioSource audioSource;

    private Animator anim;
    private Rigidbody rig;
    private bool portaAbriu = false;

    // Start is called before the first frame update
    void Start()
    {
        
        anim = this.GetComponent<Animator>();
        audioSource = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (abrirPorta && !portaAbriu)
        {
            anim.SetTrigger("Abrir");
            portaAbriu = true;

            if(audioSource != null)
            {
                audioSource.Play();
            }
            Destroy(help.gameObject, 5);
            Destroy(this.gameObject.GetComponent<Botao>(),5);

        }


    }

    public void AbrirPortao()
    {   //chama o scripts portao
        portao.GetComponent<PortaTumba>().abrirPortao = true;

        Destroy(this.GetComponent<Animator>());
        
    }
}
