using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Member2Option : MenuChoice
{
    public override void SetUpCall()
    {

        GameObject heroGO = GameObject.FindWithTag("Mage");

        EquipedItems equipedItems = heroGO.GetComponent<EquipedItems>();
        
        Debug.Log("Member2 Setup");

        GameObject menu = GameObject.FindWithTag("MenuManager");

        MenuSetup menuSetup = menu.GetComponent<MenuSetup>();
        MenuManager menuManager = menu.GetComponent<MenuManager>();
        
        menuSetup.SetUpMageSheet();

        menuManager.pointerControl.move(MenuManager.MenuOptions[MenuManager.optionSelected]);
    }
}
