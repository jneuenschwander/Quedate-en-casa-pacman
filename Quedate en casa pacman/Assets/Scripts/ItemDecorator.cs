using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDecorator : Item
{
    protected Item Item;

    public ItemDecorator(Item item)
    {
        this.Item = item;
    }

    public Item DropItem
    {
        get => Item;
        set => Item = value;
    }

    public override int Puntaje()
    {
        if (this.Item != null)
        {
            return this.Item.Puntaje();
        }
        else
        {
            return 0;
        }
    }
}
