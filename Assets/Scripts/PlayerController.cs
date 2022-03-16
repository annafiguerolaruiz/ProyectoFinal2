using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Velocidad del Tanque
    private float speed = 0.5f;
    //Velocidad del giro del Tanque
    private float turnSpeed = 40f;

    public float horizontalInput;
    public float forwardInput;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Movimiento frontal tanque
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Movimiento rotatorio del tanque
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);


     }
}
