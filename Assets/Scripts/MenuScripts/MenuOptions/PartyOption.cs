using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyOption : MenuChoice
{

    public override void SetUpCall()
    {
        GameObject menu = GameObject.FindWithTag("MenuManager");

        MenuSetup menuSetup = menu.GetComponent<MenuSetup>();
        MenuManager menuManager = menu.GetComponent<MenuManager>();
        
        menuSetup.SetUpPartyHUD();

        menuManager.pointerControl.move(MenuManager.MenuOptions[MenuManager.optionSelected]);

    }
}
