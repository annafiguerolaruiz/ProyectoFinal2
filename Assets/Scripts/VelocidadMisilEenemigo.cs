using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocidadMisilEenemigo : MonoBehaviour
{
    public float speed = 5f;
    // Update is called once per frame
    void Update()
    {

        //Movimiento misil
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
