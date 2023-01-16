using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ControlPlayer : MonoBehaviour
{
    public Animator playerAnim;
    public NavMeshAgent playerNav;
    public int tiro,lastPos;
    public GameObject Player;
    public bool llegue,gane;
    public Transform []posiciones=new Transform[110];
    // Update is called once per frame
    void Update()
    {
        if (lastPos >= 100)
            gane = true;
        else
        {
            avanza();
            if (Vector3.Distance(Player.transform.position, posiciones[lastPos].position) < 0.4f && lastPos <100)
            {
                playerAnim.SetInteger("Estado", 0);
                verificaCasilla();
            }
        }
        

    }

    void avanza()
    {
        while(tiro > 0)
        {
            llegue = false;
            playerAnim.SetInteger("Estado",1);
            playerNav.destination = posiciones[lastPos].position;
            if(lastPos<100)
                lastPos++;
            tiro--;
        }
        
    }

    void verificaCasilla()
    {
        if (lastPos == 5)
        { 
            playerNav.destination = posiciones[57].position;
            playerAnim.SetInteger("Estado", 3);
            lastPos = 58;
        }
        if (lastPos == 14)
        {
            playerNav.destination = posiciones[48].position;
            playerAnim.SetInteger("Estado", 3);
            lastPos =49;
        }
        if (lastPos == 53)
        {
            playerNav.destination = posiciones[71].position;
            playerAnim.SetInteger("Estado", 3);
            lastPos =72;
        }
        if (lastPos == 64)
        {
            playerNav.destination = posiciones[82].position;
            playerAnim.SetInteger("Estado", 3);
            lastPos =83;
        }

        if (lastPos == 38)
        {
            playerNav.destination = posiciones[19].position;
            playerAnim.SetInteger("Estado", 2);
            lastPos = 20;
        }
        if (lastPos == 51)
        {
            playerNav.destination = posiciones[9].position;
            playerAnim.SetInteger("Estado", 2);
            lastPos = 10;
        }
        if (lastPos == 76)
        {
            playerNav.destination = posiciones[53].position;
            playerAnim.SetInteger("Estado", 2);
            lastPos = 54;
        }
        if (lastPos == 91)
        {
            playerNav.destination = posiciones[72].position;
            playerAnim.SetInteger("Estado", 2);
            lastPos = 73;
        }
        if (lastPos == 97)
        {
            playerNav.destination = posiciones[60].position;
            playerAnim.SetInteger("Estado", 2);
            lastPos = 61;
        }
    }
}
