using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item 
{
    //parent item class, which will be inherited by other sub-class of sub types of item

    public enum Rarity
    {
        Common,
        Uncommon,
        Rare,
        Epic,
        Legendary
    }
    public Rarity itemRarity = Rarity.Common;
    public string itemName = "item";

    public Sprite itemImage;

    public void SetRarity(Rarity newRarity)
    {
        itemRarity = newRarity;
    }

    public void SetName(string newName)
    {
        itemName = newName;
    }

    public virtual void GetOptions()
    {
        Debug.Log("options got");
    }
    
}
