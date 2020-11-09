using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController Instance;
    [SerializeField] private GameObject gameOverText;
    [SerializeField] private GameObject gameWinText;
    public Player jugador = new Player();
    public bool isDead = false;
    
    private void Awake()
    {
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
        if (isDead && Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // control para reiniciar el juego
        }
    }
    public void Ganar()
    {
        if (jugador.Puntaje >= 49)
        {
            isDead = true;
            gameWinText.SetActive(enabled);
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
            gameOverText.SetActive(enabled);
            if (isDead && Input.GetKey(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name); // control para reiniciar el juego
            }
        }
    }
}
