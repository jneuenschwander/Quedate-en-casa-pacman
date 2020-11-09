
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vitamine : ItemDecorator
{
    public Pill _pill;
    public Vitamine(Item Item) : base(Item)// !!!!verificar si funciona
    {
        this._pill =  (Pill)Item;
    }

    public override int Puntaje()
    {
        return base.Puntaje() + 2;
    }
}
