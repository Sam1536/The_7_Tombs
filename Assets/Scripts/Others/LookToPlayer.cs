using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookToPlayer : MonoBehaviour
{
    private GameObject player;
    private float distance = 0f;

    public float _maxDistance = 4f;
    public string playerTag = "Player";

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag(playerTag); 
        this.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(this.transform.position, player.transform.position);

    }

    private void FixedUpdate()
    {
        if(distance <= _maxDistance)
        {
            this.GetComponent<SpriteRenderer>().enabled = true;
            this.transform.LookAt(player.transform.position);
        }
        else
        {
            this.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
