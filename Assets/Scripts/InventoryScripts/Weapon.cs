using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : EquipableItem
{
    public enum WeaponType
    {
        Sword,
        Shield,
        Staff,
        Bow
    }
    public WeaponType itemWeaponType;
    public int itemPhysicalDamage;
    public int itemMagicDamage;


}
