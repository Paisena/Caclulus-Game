using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class EquipedItems : MonoBehaviour
{
    Unit unit;
    private Armor helmet;
    public Armor Helmet
    {
        get { return helmet; }
        set
        {
            if(value.itemArmorType == Armor.ArmorType.Helm)
            {
                helmet = value;
            }
            else
            {
                Debug.Log("Not the right item type"); // add a method which will tell the menu this 
            }
        }
    }
    private Armor chest;
    public Armor Chest
    {
        get { return chest; }
        set
        {
            if(value.itemArmorType == Armor.ArmorType.Chest)
            {
                chest = value;
            }
            else
            {
                Debug.Log("Not the right item type"); // add a method which will tell the menu this 
            }
        }
    }
    private Armor legs;
    public Armor Legs
    {
        get { return legs; }
        set
        {
            if(value.itemArmorType == Armor.ArmorType.Legs)
            {
                legs = value;
            }
            else
            {
                Debug.Log("Not the right item type"); // add a method which will tell the menu this 
            }
        }
    }
    private Armor boots;
    public Armor Boots
    {
        get { return boots; }
        set
        {
            if(value.itemArmorType == Armor.ArmorType.Boots)
            {
                boots = value;
            }
            else
            {
                Debug.Log("Not the right item type"); // add a method which will tell the menu this 
            }
        }
    }

    private Weapon _weapon;
    public Weapon weapon
    {
        get { return _weapon; }
        set
        {
            _weapon = value;
        }
        
    }

    private void Start() 
    {
        unit = GetComponent<Unit>();    
    }

    // public void EquipItem(Weapon newWeapon)
    // {
    //     weapon = newWeapon;
    //     unit.updateStats();
    // }

    // public void EquipItem(Armor newArmor)
    // {
    //     Helmet = newArmor;
    //     Chest = newArmor;
    //     Legs = newArmor;
    //     Boots = newArmor;
    //     unit.updateStats();
    //     Debug.Log("item updated");

    // }

    public void EquipItem(Item newItem)
    {
        Debug.Log(newItem.GetType());
        try
        {
            weapon = (Weapon)newItem;
            Debug.Log(unit.damage);
            //unit.damage = _weapon.itemPhysicalDamage + unit.baseDamage;
            unit.updateStats();
            return;
        }
        catch
        {

        }
        try
        {
            Helmet = (Armor)newItem;
            Debug.Log("equipped");
            unit.updateStats();
            return;
        } catch(Exception e)
        {Debug.Log(e);}
        try
        {
            Chest = (Armor)newItem;
            return;
        } catch{}
        try
        {
            Legs = (Armor)newItem;
            return;
        }catch{}
        try
        {
            Boots = (Armor)newItem;
            return;
        } catch{}

        
    }

    public Item[] GetItems()
    {
        return new Item[] {helmet, chest, legs, boots, _weapon};
    }
}
