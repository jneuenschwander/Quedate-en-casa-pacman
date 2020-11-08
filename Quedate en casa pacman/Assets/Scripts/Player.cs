using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int vida = 3;
    private int puntaje = 0;

    public int Vida
    {
        get => vida;
        set => vida = value;
    }

    public int Puntaje
    {
        get => Puntaje;
        set => Puntaje = value;
    }
}
