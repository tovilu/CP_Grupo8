using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{

    Transform player;

    UnityEngine.AI.NavMeshAgent nav;

    private Animator anim;

    bool correr = false;
    bool atacar = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("PLAYER").transform;
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("corriendo", correr);
        anim.SetBool("atacar", atacar);

        if (correr == true)      
            nav.SetDestination(player.position);          
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PLAYER")
        {
            if (correr == false)
                correr = true;
            else
                atacar = true;
        }
            

    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "PLAYER")
        {
            if (atacar == true)
                atacar = false;
            else
                correr = false;
        }
    }
}
