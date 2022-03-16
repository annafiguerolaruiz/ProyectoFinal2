using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MenuPrincial()
    {
        SceneManager.LoadScene("Juego");

    }

    public void MenuControls()
    {
        SceneManager.LoadScene("Controls");

    }

    public void Back()
    {
        SceneManager.LoadScene("Menu");

    }

    public void Exit()
    {
        Application.Quit();
    }

}
