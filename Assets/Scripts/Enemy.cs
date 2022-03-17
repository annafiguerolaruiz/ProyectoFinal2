using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int CurrentLive;
    private int Daño = 1;
    private int Vida = 8;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        //CurrentLive = Vida;
    }

    public void OnCollissionEnter(Collider otherCollider)
    {
        //Cuando la bala colisiona contra el enemigo, el mismo, va perdiendo vida
        if(gameObject && otherCollider.gameObject.CompareTag("Bala"))
        {
            //HacerDaño(1);
            CurrentLive--;
            Debug.Log(CurrentLive);
            Destroy(otherCollider.gameObject);


            //Cuando la vida del enemigo llega a 0 , este desaparece
            if (CurrentLive == 0)
            {
                print("hola");
               
                Destroy(gameObject);

            }
        }
    }

    void HacerDaño( int damage)
    {
        CurrentLive -= damage;
    }
}
