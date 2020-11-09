using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Pill pill = new  Pill();

    public Vitamine vitamine = new Vitamine(new Pill());

    public Transform spawn;   


    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("SmallPill"))
        {
            GameController.Instance.jugador.Puntaje += pill.Puntaje();
            print(GameController.Instance.jugador.Puntaje);
            Destroy(collision.gameObject);
        }
        else if(collision.gameObject.CompareTag("Vitamina"))
        {
            GameController.Instance.jugador.Puntaje += vitamine.Puntaje();
            print(GameController.Instance.jugador.Puntaje);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Coronavirus"))
        {
            GameController.Instance.jugador.Vida -= 1;
            gameObject.transform.position = spawn.position;
        }
    
    }

    
}
