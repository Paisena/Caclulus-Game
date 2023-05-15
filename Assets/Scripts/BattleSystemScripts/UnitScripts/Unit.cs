using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unit : MonoBehaviour
{

    public string unitName;
    public int unitLevel;
    public int damage;
    public int baseDamage = 10;
    public int baseMaxHP = 100;
    public int mapHP;
    public int currentHp;
    public int defense;
    public int baseDefense = 10;
    public EquipedItems equipedItems;
    public bool isAlive = true;
    System.Random rnd = new System.Random();

    private void Awake() {
        
    }
    private void Start()
    {
        
    }

    public void updateStats()
    {
        defense = 0;

        try
        {
            damage = equipedItems.weapon.itemPhysicalDamage + baseDamage;
        }
        catch 
        {
            damage = baseDamage;
        }
        try
        {
            defense += equipedItems.Helmet.itemDefense;
            
        }
        catch 
        {
        }
        try
        {
            defense += equipedItems.Chest.itemDefense;
            
        }
        catch 
        {
        }
        try
        {
            defense +=  equipedItems.Legs.itemDefense;
            
        }
        catch 
        {
        }
        try
        {
            defense +=  equipedItems.Boots.itemDefense;
            
        }
        catch 
        {
        }
        defense += baseDefense;
        mapHP = baseMaxHP;
        Debug.Log("stats updated");
    }

    private void OnValidate() {
        //updateStats();
    }

    public bool TakeDamage(int dmg, Slider slider)
    {

        
        currentHp -= dmg;
        slider.value = currentHp;
        Debug.Log($"health: {currentHp}");
        if (currentHp <= 0)
        {
            isAlive = false;
            return true;
        }
        else
        {
            return false;
        }
        
    }
    public int chooseTarget()
    {
        int target;

        bool hasAttacked = false;

        System.Random rnd = new System.Random();

        GameObject heroGo = GameObject.FindWithTag("Hero");
        GameObject mageGo = GameObject.FindWithTag("Mage");
        GameObject archerGO = GameObject.FindWithTag("Archer");

        Hero hero = heroGo.GetComponent<Hero>();
        Archer archer = archerGO.GetComponent<Archer>();
        Mage mage = mageGo.GetComponent<Mage>();

        while(!hasAttacked)
        {
            target = rnd.Next(1,3);

            switch (target)
            {
                case 1:
                    if(!hero.isAlive)
                    {
                        Debug.Log("hero is dead");
                    }
                    else
                    {
                        Debug.Log("attacking hero");
                        return target;
                    }
                    break;

                case 2:
                if(!archer.isAlive)
                    {
                        Debug.Log("archer is dead");
                    }
                    else
                    {
                        Debug.Log("attacking archer");
                        return target;
                    }
                    break;

                case 3:
                if(!mage.isAlive)
                    {
                        Debug.Log("mage is dead");
                    }
                    else
                    {
                        Debug.Log("attacking mage");
                        return target;
                    }
                    break;

                default:
                break;
            }
        }
        return 1;
    }
}
