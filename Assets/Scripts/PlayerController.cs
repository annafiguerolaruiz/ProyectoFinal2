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

    public int Vida = 6;

    public GameObject GameOver;
    public GameObject Wine;

    private Vector3 InitialPos = new Vector3(-10.0089998f, 0.488999993f, 0.303000003f);

    // Start is called before the first frame update
    void Start()
    {
        transform.position = InitialPos;
        GameOver.SetActive(false);
        Wine.SetActive(false);
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
    
    
    public void OnCollisionEnter(Collision otherCollider)
    {

       
        //Cuando la bala colisiona contra el player, el mismo, va perdiendo vida
        if (otherCollider.gameObject.CompareTag("BalaEnemiga"))
        {
            Destroy(otherCollider.gameObject);
            Vida = Vida - 1;

            if (Vida <= 0)
            {
               GameOver.SetActive(true);


            }



        }

        if (otherCollider.gameObject.CompareTag("WINE"))
        {
            Wine.SetActive(true);
        }
    }

}
