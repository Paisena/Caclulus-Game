using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemOption : MenuChoice
{
    
    public ItemInformation itemInformation;

    private void Start()
    {
        itemInformation = GetComponent<ItemInformation>();    
    }

    public override void SetUpCall()
    {

        GameObject menu = GameObject.FindWithTag("MenuManager");

        MenuSetup menuSetup = menu.GetComponent<MenuSetup>();
        MenuManager menuManager = menu.GetComponent<MenuManager>();
        
        if(itemInformation.itemType is EquipableItem)
        {
            menuSetup.SetUpEquip();
        }
        if(itemInformation.itemType is UseableItem)
        {
            menuSetup.SetUpUse();
        }
        if(itemInformation.itemType is QuestItem)
        {
            menuSetup.SetUpQuest();
        }

        menuManager.pointerControl.move(MenuManager.MenuOptions[MenuManager.optionSelected]);
    }
}
