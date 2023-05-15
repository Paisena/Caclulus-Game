using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : EquipableItem
{
    public enum ArmorType
    {
        Helm,
        Chest,
        Legs,
        Boots
    }
    public ArmorType itemArmorType; 
    public int itemDefense;

    public Armor()
    {

    }
}
