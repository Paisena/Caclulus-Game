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
    private GameObject _enemyFighting;
    public GameObject enemyFighting;
   

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
}
