using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAScript : MonoBehaviour
{

    public int estado; //0 es centro, 1 es derecha, 2 es izquierda
    bool cambiar = false;

    public float dificultad;
    public float inicial;

    public GameObject personaje;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (cambiar == true)
        {   
            cambiar = false;       
            CambiaDireccion();            
        }
    }

    //Si se choca contra Obstaculo y el random se cumple esquiva el obstaculo
    void OnCollisionEnter(Collision collision)
    {      
        if (collision.gameObject.tag == "Obstaculo")
            if (Random.value <= dificultad)
                cambiar = true;
        if (collision.gameObject.tag == "Eliminatorio")
            Destroy(personaje);
    }

    //metodo que le dice donde irse
    private void CambiaDireccion()
    {
        Vector3 currentPosition = transform.position;
        if (estado == 0)
        {
            estado = (int)(1.5f + Random.value);
            if (estado == 1)
                currentPosition.x += 12;
            else
                currentPosition.x -= 12;
        }
        else
        {
            estado = 0;
            currentPosition.x = inicial;
        }
        transform.position = currentPosition;
    }

}
