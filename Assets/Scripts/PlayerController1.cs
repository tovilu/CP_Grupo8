using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{

    //Controles
    private PlayerActionController playerActionsControls;

    public GameObject personaje;

    //booleano que activa los controles 
    int activo = 1;
    //Tiempo para retardo de nuevo input
    float controles = 0;

    void Awake()
    {
        playerActionsControls = new PlayerActionController();
    }

    private void OnEnable()
    {
        playerActionsControls.Enable();
    }

    private void OnDisable()
    {
        playerActionsControls.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
    //Si se choca con un obstaculo
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Eliminatorio")
            Destroy(personaje);
    }

    // Update is called once per frame
    void Update()
    {
        //Input
        float mx = playerActionsControls.Prota.MoveX.ReadValue<float>();

        //Tiempo del ultimo input
        controles += Time.deltaTime;

        Vector3 currentPosition = transform.position;

        //Condiciones del input para moverse derecha o izquierda
        if (mx < 0 && activo > 0)
        {
            if (transform.position.x > -12)
            {
                currentPosition.x -= 12;
                activo = 0;
                controles = Time.deltaTime;
            }     
        }
        else if (mx > 0 && activo > 0)
        {
            if (transform.position.x < 12)
            {
                currentPosition.x += 12;
                activo = 0;
                controles = Time.deltaTime;
            }    
        }
        if (activo == 0)
        {
            if (controles >= 0.2f)
            {
                activo++;
                controles = 0;
            }
        }


        transform.position = currentPosition;
    }
}
