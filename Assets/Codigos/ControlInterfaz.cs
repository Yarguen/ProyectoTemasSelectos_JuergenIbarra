using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlInterfaz : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void escenaJuego()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void escenaInstrucciones()
    {
        SceneManager.LoadScene("Instrucciones");
    }

    public void escenaInstrucciones2()
    {
        SceneManager.LoadScene("Instrucciones2");
    }

    public void escenaMenu()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void salir()
    {
        Application.Quit();
    }
}
