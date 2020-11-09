using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using TMPro;

public class GameController : MonoBehaviour
{
    public static GameController Instance;
    [SerializeField] public GameObject canvasGameOver;
    [SerializeField] public GameObject canvasGameWin;
    public TextMeshProUGUI textWin;
    public TextMeshProUGUI textLost;
    public Player jugador = new Player();
    public bool isDead = false;

    
    private void Awake()
    {
        jugador.Puntaje = 0;
        if (GameController.Instance == null) // control donde nos aseguramos que solo exista un instacia singleton
        {
            GameController.Instance = this; 
        }else if (GameController.Instance != this)
        {
            Destroy(gameObject);
            Debug.LogWarning("GameController a sido instanciado por segunda vez, evento ilegal.");
        }
    }

    private void Update()
    {
        Ganar();
        Perder();
        if (isDead && Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // control para reiniciar el juego
        }
    }
    public void Ganar()
    {
        if (jugador.Puntaje >=63)
        {

            textWin.SetText(jugador.Puntaje.ToString());
            isDead = true;
            canvasGameWin.SetActive(enabled);
            if (isDead && Input.GetKey(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name); // control para reiniciar el juego
            }
        }
    }
    public void Perder()
    {
        if (jugador.Vida == 0)
        {
            isDead = true;
            textLost.SetText(jugador.Puntaje.ToString());
            canvasGameOver.SetActive(enabled);
            if (isDead && Input.GetKey(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name); // control para reiniciar el juego
            }
            
        }
    }
}
