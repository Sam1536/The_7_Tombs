using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator anim;
    private float velocidade;
    public AudioClip[] passosSom = new AudioClip[2];
    private AudioSource audioSource;
    private int tipoChao = 0;

    public FinalizandoJogo finalizarJogo; 

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        if(velocidade > 0 && !audioSource.isPlaying)
        {
            audioSource.clip = passosSom[tipoChao];
            audioSource.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!finalizarJogo.terminouJogo)
        {

            velocidade = Input.GetAxis("Vertical");

            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.Joystick1Button2))
            {
                velocidade *= 2f;
            }

            this.transform.Rotate(new Vector3(0, ((90 * Input.GetAxis("Horizontal") * Time.deltaTime)), 0));

            anim.SetFloat("Velocidade", velocidade);

            //Debug.Log(velocidade);    
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Chão"))
        {
            tipoChao = 1;
        }
        else
        {
            tipoChao = 0;
        }
    }
}
