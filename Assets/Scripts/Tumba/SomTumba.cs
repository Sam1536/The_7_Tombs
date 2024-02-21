 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomTumba : MonoBehaviour
{
    public bool entraTumba;
    public AudioSource audioSource;

    private bool coliderPlayer;
    public string playerTag = "Player";

    // Start is called before the first frame update
    void Start()
    {
        //audioSource = GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag) && entraTumba)
        {
            audioSource.enabled = true;
            audioSource.Play();
            coliderPlayer = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(playerTag) && !entraTumba)
        {
            audioSource.enabled = false;
            coliderPlayer = false;
        }
    }
}
