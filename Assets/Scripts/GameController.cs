using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Image[] imagensReliquias = new Image[7];
    public static int indiceReliquias = -1;
    
    /* 0 = Anubis
     * 1 = Ceramica
     * 2 = Cruz
     * 3 = Escaravelho
     * 4 = Hieroglifo
     * 5 = Olho de Horus
     * 6 = Ouruboros
     */

    public int totalItensColetados = 0;

    // Start is called before the first frame update
    void Start()
    {
        OcultarItens();
        //totalItensColetados = 7;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(indiceReliquias > -1)
        {
            imagensReliquias[indiceReliquias].enabled = true;
            totalItensColetados++;
            indiceReliquias = -1;
        }
    }

    public void OcultarItens()
    {
        for(int i = 0; i < imagensReliquias.Length; i++)
        {
            imagensReliquias[i].enabled = false;
        }
    }
}
