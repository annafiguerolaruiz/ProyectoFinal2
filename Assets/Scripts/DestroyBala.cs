using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBala : MonoBehaviour
{
    private float TiempoBala = 10f;
    private float CuentaAtras;

    
    // Start is called before the first frame update
    void Start()
    {
        CuentaAtras = TiempoBala;
    }

    // Update is called once per frame
    void Update()
    {
        CuentaAtras -= Time.deltaTime;
        {
            Debug.Log("BUM");
            Destroy(gameObject);
        }
       
    }
}
