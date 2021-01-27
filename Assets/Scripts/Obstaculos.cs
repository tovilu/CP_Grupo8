using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    [SerializeField]private float speed;

    float p;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 currentPosition = transform.position;
        transform.position = RandomPosition(currentPosition);     
    }

    //Para que los obstaculos cambien de posicion x
    private Vector3 RandomPosition(Vector3 currentPosition)
    {
        p = Random.value;
        UnityEngine.Random.InitState((int)(System.DateTimeOffset.Now.ToUnixTimeMilliseconds()));
        p = Random.value;
        if (p < 0.333f)
            currentPosition.x = -12.0f;
        else if (p < 0.666f)
            currentPosition.x = 0.0f;
        else
            currentPosition.x = 12.0f;
        return currentPosition;
    }

    // Update is called once per frame
    void Update()
    {
        speed += 0.001f;
        Vector3 currentPosition = transform.position;
        currentPosition.z -= 5 * speed * Time.deltaTime;
        //Si pasan detras de la camara su posicion cambia al final del escenario para que vuelva a salir creando efecto de infinitos obstaculos
        if(currentPosition.z < -20)
        {
            currentPosition = RandomPosition(currentPosition);
            currentPosition.z += 300;
        }
        transform.position = currentPosition;
    }
}
