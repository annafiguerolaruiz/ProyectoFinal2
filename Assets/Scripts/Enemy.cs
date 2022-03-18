using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    public int Vida = 8;
    public ParticleSystem Explosion;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
    
    }

    public void OnCollisionEnter(Collision otherCollider)
    {
       
        Debug.Log("BALA");
        //Cuando la bala colisiona contra el enemigo, el mismo, va perdiendo vida
        if (otherCollider.gameObject.CompareTag("Bala"))   
        {
            Destroy(otherCollider.gameObject);
            Vida = Vida - 1;

            if (Vida<=0)
            {
                Destroy(gameObject);
                Vector3 offset = new Vector3(0, 0, 0);
                var inst = Instantiate(Explosion, transform.position + offset, Explosion.transform.rotation);
                inst.Play();

            }
           
        }
    }


}
