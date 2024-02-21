using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerReliquia : MonoBehaviour
{
    public GameObject reliquia;
    public int indiceReliquia;
    

    private bool playerColider = false, pressed = false;
    public string playerTag = "Player";

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Joystick1Button1))
        {
            if (!pressed && playerColider)
            {
                pressed = true;
                audioSource.Play();
                GameController.indiceReliquias = indiceReliquia;
                Destroy(reliquia.gameObject,1);
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
