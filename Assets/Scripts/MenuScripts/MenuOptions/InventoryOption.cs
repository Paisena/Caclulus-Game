using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryOption : MenuChoice
{
    public override void SetUpCall()
    {
        GameObject menu = GameObject.FindWithTag("MenuManager");

        MenuSetup menuSetup = menu.GetComponent<MenuSetup>();
        MenuManager menuManager = menu.GetComponent<MenuManager>();
        
        menuSetup.SetUpInventoryHUD();

        menuManager.pointerControl.move(MenuManager.MenuOptions[MenuManager.optionSelected]);
    }
}
