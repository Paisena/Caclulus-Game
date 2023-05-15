using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipMageOption : MenuChoice
{
    public override void SetUpCall()
    {
        GameObject menu = GameObject.FindWithTag("MenuManager");

        MenuSetup menuSetup = menu.GetComponent<MenuSetup>();
        MenuManager menuManager = menu.GetComponent<MenuManager>();

        GameObject mageGO = GameObject.FindWithTag("Mage");

        EquipedItems equipedItems = mageGO.GetComponent<EquipedItems>();

        GameObject playerInventoryGO = GameObject.FindWithTag("Inventory");

        Inventory playerInventory = playerInventoryGO.GetComponent<Inventory>();

        Item item = playerInventory.inventory[playerInventory.selectedItem];

        equipedItems.EquipItem(item);

        menuSetup.ExitCharSelect();

        menuManager.pointerControl.move(MenuManager.MenuOptions[MenuManager.optionSelected]);
    }
}
