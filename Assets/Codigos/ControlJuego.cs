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
    public TextMeshProUGUI texto,texto2;
    public GameObject Logo,botonTirar,botonSalir,botonCasillaEspecial,botonAceptar,tablero;
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

        if (Player1.lastPos == 5 || Player2.lastPos==5)
        {
            botonAceptar.SetActive(true);
            botonCasillaEspecial.SetActive(true);
            //tablero.SetActive(false);
            texto2.text = "Felicidades\nAcabas de pasar la mayor seriacion de la FI\navanza a la casilla 58";
        }
        if (Player1.lastPos == 14 || Player2.lastPos == 14)
        {
            botonAceptar.SetActive(true);
            botonCasillaEspecial.SetActive(true);
            //tablero.SetActive(false);
            texto2.text = "Felicidades\npasaste Bases de datos con Campos\n avanza a la casilla 49";
        }
        if (Player1.lastPos == 53 || Player2.lastPos == 53)
        {
            botonAceptar.SetActive(true);
            botonCasillaEspecial.SetActive(true);
            //tablero.SetActive(false);
            texto2.text = "Felicidades\nterminaste tus creditos de la carrera\navanza a la casilla 72";
        }
        if (Player1.lastPos == 64 || Player2.lastPos == 64)
        {
            botonAceptar.SetActive(true);
            botonCasillaEspecial.SetActive(true);
            //tablero.SetActive(false);
            texto2.text = "Felicidades\naceptaron tu tesis\navanza a la casilla 83";
        }
        if (Player1.lastPos == 38 || Player2.lastPos == 38)
        {
            botonAceptar.SetActive(true);
            botonCasillaEspecial.SetActive(true);
            //tablero.SetActive(false);
            texto2.text = "lo siento\nreprobaste algebra lineal\nregresa a la casilla 20";
        }
        if (Player1.lastPos == 51 || Player2.lastPos == 51)
        {
            botonAceptar.SetActive(true);
            botonCasillaEspecial.SetActive(true);
            //tablero.SetActive(false);
            texto2.text = "lo siento\nte atraparon copiando en un examen\nregresa a la casilla 10";
        }
        if (Player1.lastPos == 76 || Player2.lastPos == 76)
        {
            botonAceptar.SetActive(true);
            botonCasillaEspecial.SetActive(true);
            //tablero.SetActive(false);
            texto2.text = "lo siento\ndejaste de ser regular y te quitaron la beca\nregresa a la casilla 54";
        }
        if (Player1.lastPos == 91 || Player2.lastPos == 91)
        {
            botonAceptar.SetActive(true);
            botonCasillaEspecial.SetActive(true);
            //tablero.SetActive(false);
            texto2.text = "lo siento\nreprobaste tu ultima materia\nregresa a la casilla 73";
        }
        if (Player1.lastPos == 97 || Player2.lastPos == 97)
        {
            botonAceptar.SetActive(true);
            botonCasillaEspecial.SetActive(true);
            //tablero.SetActive(false);
            texto2.text = "lo siento\ntu sinodal esta decepcionado de tu trabajo\nregresa a la casilla 61";
        }

        if (ganoP1)
        {
            texto.text = "Felicidades Jugador 1\nGanaste!";
            Logo.SetActive(true);
            botonTirar.SetActive(false);
            botonSalir.SetActive(true);

        }
        if (ganoP2)
        {
            texto.text = "Felicidades Jugador 2\nGanaste!";
            Logo.SetActive(true);
            botonTirar.SetActive(false);
            botonSalir.SetActive(true);

        }
    }

    public void quitaBotonAceptar()
    {
        //tablero.SetActive(true);
        botonCasillaEspecial.SetActive(false);
        botonAceptar.SetActive(false);
        botonTirar.SetActive(true);
            
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
