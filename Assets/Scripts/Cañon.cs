using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañon : MonoBehaviour
{
    public GameObject MisilPrefab;
    private PlayerController playercontroller;
    public AudioClip disparo;
    private AudioSource playerAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        playercontroller = GameObject.Find("Player").GetComponent<PlayerController>();
        playerAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Instanciar el Misil
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            
            MisilPrefab.transform.position = gameObject.GetComponent<Transform>().position;
            MisilPrefab.transform.rotation = gameObject.GetComponent<Transform>().rotation;
            Instantiate(MisilPrefab, MisilPrefab.transform.position, MisilPrefab.transform.rotation);
            playerAudioSource.PlayOneShot(disparo, 1f);
        }
    }
}
