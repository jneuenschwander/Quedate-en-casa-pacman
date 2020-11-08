using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDecorator : Item
{
    protected Item dropItem;

    public ItemDecorator(Item dropItem)
    {
        this.dropItem = dropItem;
    }

    public Item DropItem
    {
        get => dropItem;
        set => dropItem = value;
    }

    public override int Puntaje()
    {
        if (this.dropItem != null)
        {
            return this.dropItem.Puntaje();
        }
        else
        {
            return 0;
        }
    }
}
