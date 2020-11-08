using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pill : Item
{
    private int _valor = 1;
    public override int Puntaje()
    {
        return _valor;
    }
}
