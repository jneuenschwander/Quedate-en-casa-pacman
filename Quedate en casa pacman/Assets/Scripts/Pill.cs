using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pill : Item
{
    public int valor = 1;
  
    public override int Puntaje()
    {
        return valor;
    }
}
