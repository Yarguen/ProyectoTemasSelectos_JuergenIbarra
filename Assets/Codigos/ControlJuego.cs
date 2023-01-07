using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ControlJuego : MonoBehaviour
{
    public int valorTiro;
    public bool finTurnoP1, finTurnoP2,ganoP1,ganoP2;
    public ControlPlayer Player1, Player2;
    public TextMeshProUGUI texto;
    public GameObject Logo,botonTirar,botonSalir;
    // Start is called before the first frame update
    void Start()
    {
        texto.text = "Esperando a \ntirar";
        finTurnoP2 = true;
    }

    // Update is called once per frame
    void Update()
    {
        ganoP1 = Player1.gane;
        ganoP2 = Player2.gane;

        if (ganoP1)
        {
            texto.text = "Felicidades Jugador 1\nGanaste!";
            Logo.SetActive(true);
            botonTirar.SetActive(false);
            botonSalir.SetActive(true);

        }
    }

    public void tirar()
    {
        if (ganoP1 != true || ganoP2 != true)
        {
            if (finTurnoP1 == true)
            {
                valorTiro = Random.Range(1, 6);
                Player2.tiro = valorTiro;
                texto.text = "Turno Jugador 2\n Tiraste un:" + valorTiro.ToString();
                finTurnoP2 = true;
                finTurnoP1 = false;
            }
            else if (finTurnoP2 == true)
            {
                valorTiro = Random.Range(1, 6);
                Player1.tiro = valorTiro;
                texto.text = "Turno Jugador 1\n Tiraste un:" + valorTiro.ToString();
                finTurnoP1 = true;
                finTurnoP2 = false;
            }
        }
    }
}
