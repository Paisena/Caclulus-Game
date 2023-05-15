using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Member1Option : MenuChoice
{
    public override void SetUpCall()
    {
        Debug.Log("Member1 Setup");

        GameObject menu = GameObject.FindWithTag("MenuManager");

        MenuSetup menuSetup = menu.GetComponent<MenuSetup>();
        MenuManager menuManager = menu.GetComponent<MenuManager>();
        
        menuSetup.SetUpHeroSheet();

        menuManager.pointerControl.move(MenuManager.MenuOptions[MenuManager.optionSelected]);
    }
}
