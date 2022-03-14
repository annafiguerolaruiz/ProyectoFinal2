using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Displacament : MonoBehaviour
{
    public float Velocidad = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //COMANDOS (TECLAS) DE LOS MOVIMIENTOS DEL JUGADOR 
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Velocidad * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Velocidad * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
            {
            transform.Translate(Vector3.forward * Velocidad * Time.deltaTime);
            }
    }
}
