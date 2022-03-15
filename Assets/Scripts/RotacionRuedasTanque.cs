using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionRuedasTanque : MonoBehaviour
{
    private float Speed = 300f;

    public float forwardInput;

    // Update is called once per frame
    void Update()
    {

        forwardInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.right * Speed * Time.deltaTime * forwardInput);
    }

}
