using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class TampaTumba : MonoBehaviour
{
    public bool abrirTampa = false;
    public GameObject ajuda;
    public GameObject reliquia;

    private Animator anim;
    private Rigidbody rig;
    private bool tampaAbriu = false;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        rig = this.GetComponent<Rigidbody>();
        anim = this.GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(abrirTampa && !tampaAbriu)
        {
            anim.SetTrigger("Abrir");
            tampaAbriu = true;
            reliquia.SetActive(true);
           
            Destroy(ajuda.gameObject, 5);
            Destroy(this.gameObject.GetComponent<TampaTumba>(), 10);
           
        }

       
    }

    public void PlauAudio()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }

    public void AtivarRigid()
    {
        Destroy(this.GetComponent<Animator>());
        rig.useGravity = true;
    }
}
