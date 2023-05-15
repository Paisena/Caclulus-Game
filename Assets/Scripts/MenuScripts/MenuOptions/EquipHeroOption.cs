using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipHeroOption : MenuChoice
{
    public override void SetUpCall()
    {

        GameObject menu = GameObject.FindWithTag("MenuManager");

        MenuSetup menuSetup = menu.GetComponent<MenuSetup>();
        MenuManager menuManager = menu.GetComponent<MenuManager>();

        GameObject heroGO = GameObject.FindWithTag("Hero");

        EquipedItems equipedItems = heroGO.GetComponent<EquipedItems>();

        GameObject playerInventoryGO = GameObject.FindWithTag("Inventory");

        Inventory playerInventory = playerInventoryGO.GetComponent<Inventory>();

        Item item = playerInventory.inventory[playerInventory.selectedItem];
        equipedItems.EquipItem(item);

        //Debug.Log($"item is: {equipedItems.weapon.itemName}");

        menuSetup.ExitCharSelect();

        menuManager.pointerControl.move(MenuManager.MenuOptions[MenuManager.optionSelected]);
    }
}
