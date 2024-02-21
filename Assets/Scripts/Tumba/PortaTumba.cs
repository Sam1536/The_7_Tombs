    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaTumba : MonoBehaviour
{

    public  bool abrirPortao = false;
    private AudioSource audioSource;

    private Animator anim;
    private bool portaoAbriu = false;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
        anim = this.GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        if(abrirPortao && !portaoAbriu)
        {
            portaoAbriu = true;
            anim.SetTrigger("Abrir");
            if(audioSource != null)
            {
                audioSource.Play();
            }
            Destroy(this.GetComponent<PortaTumba>(),10);
        }
    }
}
