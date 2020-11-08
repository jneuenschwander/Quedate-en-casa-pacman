using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{ 
    private Pill _pill = new Pill();
    private Vitamine _vitamine = new Vitamine(new Pill());

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            UnityEngine.Debug.Log("Colisiono con player");
            if (this.gameObject.tag == "SmallPill")
            {
                GameController.Instance.jugador.Puntaje += _pill.Puntaje();
                print(GameController.Instance.jugador.Puntaje);
                this.gameObject.transform.position = new Vector3(8, 8, 0);
            }
            else if(this.gameObject.tag == "Vitamina")
            {
                GameController.Instance.jugador.Puntaje += _vitamine.Puntaje();
                print(GameController.Instance.jugador.Puntaje);
                this.gameObject.transform.position = new Vector3(8, 8, 0);
            }
            else if (this.gameObject.tag == "Coronavirus")
            {
                
            }
        }
    }

}
