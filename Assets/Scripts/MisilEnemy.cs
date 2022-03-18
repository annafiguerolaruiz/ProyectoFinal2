using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisilEnemy : MonoBehaviour
{
    public GameObject MisilEnemigo;
    public float Time = 5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstantiateMisilEnemigo",2f, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void InstantiateMisilEnemigo()
    {
        Instantiate(MisilEnemigo, transform.position, transform.rotation);
        Destroy(gameObject, Time);
}
}
