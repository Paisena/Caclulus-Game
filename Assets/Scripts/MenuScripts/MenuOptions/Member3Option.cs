using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Member3Option : MenuChoice
{
    public override void SetUpCall()
    {

        GameObject archerGO = GameObject.FindWithTag("Archer");

        EquipedItems equipedItems = archerGO.GetComponent<EquipedItems>();
        
        Debug.Log("Member1 Setup");

        GameObject menu = GameObject.FindWithTag("MenuManager");

        MenuSetup menuSetup = menu.GetComponent<MenuSetup>();
        MenuManager menuManager = menu.GetComponent<MenuManager>();
        
        menuSetup.SetUpArcherSheet();

        menuManager.pointerControl.move(MenuManager.MenuOptions[MenuManager.optionSelected]);
    }
}
