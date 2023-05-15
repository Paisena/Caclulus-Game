using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitInventory : MenuChoice
{
    public override void SetUpCall()
    {
        GameObject menu = GameObject.FindWithTag("MenuManager");

        MenuSetup menuSetup = menu.GetComponent<MenuSetup>();
        MenuManager menuManager = menu.GetComponent<MenuManager>();
        
        //Debug.Log("party exited");

        menuSetup.SetUpMainHUD();

        menuManager.pointerControl.move(MenuManager.MenuOptions[MenuManager.optionSelected]);
    }
}
