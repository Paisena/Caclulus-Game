using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuSetup : MonoBehaviour
{
    [SerializeField]
    Transform partyHud;

    [SerializeField]
    GameObject mainText;
    [SerializeField]
    GameObject inventory;
    [SerializeField]
    GameObject party;
    [SerializeField]
    GameObject exit;
    [SerializeField]
    GameObject member1;
    [SerializeField]
    GameObject member2;
    [SerializeField]
    GameObject member3;
    [SerializeField]
    GameObject exitParty;
    [SerializeField]
    GameObject exitInventory;
    [SerializeField]
    GameObject InventoryTitle;
    [SerializeField]
    Canvas canvas;
    public GameObject InventoryHUD;
    public GameObject ItemPrefab;
    public GameObject EquipableOptionsPrefab, UseableOptionsPrefab, QuestOptionsPrefab;
    public GameObject CharacterDisplayPrefab;
    public GameObject CharacterSheetPrefab;
    GameObject characterSheetDisplay;
    GameObject itemOptionsDisplay;
    GameObject characterEquipDisplay;

    GameObject[] ItemDisplayGO;
    int itemSelectedIndex;
    Vector3 exitInventoryPosition = new Vector3(4, -56, 0);

    #region setup

    public void SetUpPartyHUD()
    {
        ResetAllPositions();

        Vector3 partyHudPosition = new Vector3(-335/*/0.01602815f*/, 220/*/0.01602815f*/, 1/*/0.01602815f*/);

        partyHud.position = Vector3.Scale(partyHudPosition, canvas.transform.localScale);

        ChangeOptionsParty();

    }

    public void SetUpHeroSheet()
    {
        Vector3 setPosition = new Vector3(0, 0, 100);
        characterSheetDisplay = Instantiate(CharacterSheetPrefab, setPosition, transform.rotation, canvas.transform);

        GameObject exit = characterSheetDisplay.transform.GetChild(5).gameObject;

        ChangeOptionsCharSheet(exit);

        GameObject heroGo = GameObject.FindWithTag("Hero");

        EquipedItems equipedItems = heroGo.GetComponent<EquipedItems>();

        Item[] itemsEquiped = equipedItems.GetItems();

        for (int i = 0; i < 5; i++)
        {
            GameObject item = characterSheetDisplay.transform.GetChild(i).gameObject;

            GameObject itemSprite = item.transform.GetChild(0).gameObject;

            SpriteRenderer sprite = itemSprite.GetComponent<SpriteRenderer>();
            try
            {
                sprite.sprite = itemsEquiped[i].itemImage;
            }
            catch
            {
                //Debug.Log(itemsEquiped[4].itemImage.name);
            }

        }
    }

    public void SetUpArcherSheet()
    {
        Vector3 setPosition = new Vector3(0, 0, 100);
        characterSheetDisplay = Instantiate(CharacterSheetPrefab, setPosition, transform.rotation, canvas.transform);

        GameObject exit = characterSheetDisplay.transform.GetChild(5).gameObject;

        ChangeOptionsCharSheet(exit);

        GameObject heroGo = GameObject.FindWithTag("Archer");

        EquipedItems equipedItems = heroGo.GetComponent<EquipedItems>();

        Item[] itemsEquiped = equipedItems.GetItems();

        for (int i = 0; i < 5; i++)
        {
            GameObject item = characterSheetDisplay.transform.GetChild(i).gameObject;

            GameObject itemSprite = item.transform.GetChild(0).gameObject;

            SpriteRenderer sprite = itemSprite.GetComponent<SpriteRenderer>();
            try
            {
                Debug.Log(itemsEquiped[4].itemImage.name);
                sprite.sprite = itemsEquiped[i].itemImage;
            }
            catch
            {
                //Debug.Log(itemsEquiped[4].itemImage.name);
            }

        }
    }

    public void SetUpMageSheet()
    {
        Vector3 setPosition = new Vector3(0, 0, 100);
        characterSheetDisplay = Instantiate(CharacterSheetPrefab, setPosition, transform.rotation, canvas.transform);

        GameObject exit = characterSheetDisplay.transform.GetChild(5).gameObject;

        ChangeOptionsCharSheet(exit);

        GameObject heroGo = GameObject.FindWithTag("Mage");

        EquipedItems equipedItems = heroGo.GetComponent<EquipedItems>();

        Item[] itemsEquiped = equipedItems.GetItems();

        for (int i = 0; i < 5; i++)
        {
            GameObject item = characterSheetDisplay.transform.GetChild(i).gameObject;

            GameObject itemSprite = item.transform.GetChild(0).gameObject;

            SpriteRenderer sprite = itemSprite.GetComponent<SpriteRenderer>();
            try
            {
                sprite.sprite = itemsEquiped[i].itemImage;
            }
            catch
            {
                //Debug.Log(itemsEquiped[4].itemImage.name);
            }

        }
    }

    public void SetUpInventoryHUD()
    {

        //im going to put comment here because its to long and confusing
        ResetAllPositions();

        GameObject playerInventoryGO = GameObject.FindWithTag("Inventory");
        Inventory playerInventory = playerInventoryGO.GetComponent<Inventory>();

        TextMeshProUGUI inventoryText = InventoryHUD.GetComponentInChildren<TextMeshProUGUI>();


        ItemDisplayGO = new GameObject[playerInventory.inventory.Count];

        int itemsPerRow = 5;
        decimal rows = (decimal)playerInventory.inventory.Count / (decimal)itemsPerRow;
        int totalRows = (int)Math.Ceiling(rows);
        int itemBoxWidth = 100;
        int itemBoxHeight = 150;

        for (int i = 0; i < playerInventory.inventory.Count; i++)
        {
            //create and position each item in right spot
            Vector3 itemPosition = new Vector3(-350 + itemBoxWidth * i, itemBoxHeight, 1000);
            GameObject newItem = Instantiate(ItemPrefab, itemPosition, transform.rotation, canvas.transform);

            ItemInformation itemInformation = newItem.GetComponent<ItemInformation>();

            newItem.transform.position = Vector3.Scale(itemPosition, canvas.transform.localScale);

            //set item type so the prefab know what type it is
            itemInformation.SetItemType(playerInventory.inventory[i]);

            ItemDisplayGO[i] = newItem;

            //update item display information
            TextMeshProUGUI itemText = newItem.GetComponentInChildren<TextMeshProUGUI>();
            itemText.text = playerInventory.inventory[i].itemName;

        }

        Vector3 partyHudPosition = new Vector3(-335, 220, 1);
        InventoryHUD.transform.position = Vector3.Scale(partyHudPosition, canvas.transform.localScale);

        GameObject exitInventory = GameObject.FindGameObjectWithTag("Inventory Exit");
        Transform exitInventoryTransform = exitInventory.GetComponent<Transform>();

        exitInventoryTransform.position = new Vector3(-3.20f, 1 - totalRows, 1);

        ChangeOptionsInventory();

        MenuManager.optionSelected = 1;
    }

    public void SetUpMainHUD()
    {

        ResetAllPositions();

        inventory.SetActive(true);
        party.SetActive(true);
        mainText.SetActive(true);

        ChangeOptionsMain();
    }

    public void SetUpEquip()
    {
        Vector3 setPosition = new Vector3(0, 0, 0);
        itemOptionsDisplay = Instantiate(EquipableOptionsPrefab, setPosition, transform.rotation, canvas.transform);

        GameObject itemDescription = itemOptionsDisplay.transform.GetChild(0).gameObject;
        GameObject itemWear = itemOptionsDisplay.transform.GetChild(1).gameObject;
        GameObject itemExit = itemOptionsDisplay.transform.GetChild(2).gameObject;

        itemSelectedIndex = MenuManager.optionSelected - 2;

        GameObject InventoryGO = GameObject.FindWithTag("Inventory");
        Inventory inventory = InventoryGO.GetComponent<Inventory>();

        TextMeshProUGUI descriptionText = itemDescription.GetComponentInChildren<TextMeshProUGUI>();

        // Type itemType = inventory.inventory[itemSelectedIndex].GetType().BaseType;

        // object itemSelected = Activator.CreateInstance(itemType);

        if (inventory.inventory[itemSelectedIndex].GetType().BaseType.Name == "Weapon")
        {
            Weapon itemSelected = (Weapon)inventory.inventory[itemSelectedIndex];
            descriptionText.text = $"{itemSelected.itemName}\n Physical Damage: {itemSelected.itemPhysicalDamage}";
        }
        if (inventory.inventory[itemSelectedIndex].GetType().BaseType.Name == "Armor")
        {
            Armor itemSelected = (Armor)inventory.inventory[itemSelectedIndex];
            descriptionText.text = $"{itemSelected.itemName}\nDefense: {itemSelected.itemDefense}";
        }


        // descriptionText.text = inventory.inventory[itemSelectedIndex].itemName + "\n" + inventory.inventory[itemSelectedIndex].item

        GameObject playerInventoryGO = GameObject.FindWithTag("Inventory");

        Inventory playerInventory = playerInventoryGO.GetComponent<Inventory>();

        playerInventory.SetSelectedItem(itemSelectedIndex);

        GameObject[] options = { itemDescription, itemWear, itemExit };


        ChangeOptionsEquip(options);
    }

    public void ExitEquip()
    {
        GameObject playerInventoryGO = GameObject.FindWithTag("Inventory");

        Inventory playerInventory = playerInventoryGO.GetComponent<Inventory>();

        playerInventory.DeselectItem();
        ClearItemOptions();
        ChangeOptionsInventory();
    }

    public void ExitCharSelect()
    {
        ClearCharSelect();

        GameObject itemDescription = itemOptionsDisplay.transform.GetChild(0).gameObject;
        GameObject itemWear = itemOptionsDisplay.transform.GetChild(1).gameObject;
        GameObject itemExit = itemOptionsDisplay.transform.GetChild(2).gameObject;

        GameObject[] options = { itemDescription, itemWear, itemExit };

        GameObject playerInventoryGO = GameObject.FindWithTag("Inventory");

        Inventory playerInventory = playerInventoryGO.GetComponent<Inventory>();

        playerInventory.SetSelectedItem(itemSelectedIndex);
        // Debug.Log(playerInventory.inventory[itemSelectedIndex].GetType());

        ChangeOptionsEquip(options);
    }

    public void ExitCharSheet()
    {
        ClearCharSheet();

        SetUpPartyHUD();
    }

    public void SetUpUse()
    {

    }

    public void SetUpQuest()
    {

    }

    public void SetUpEquipChar()
    {
        Vector3 setPosition = new Vector3(0, 0, 0);
        characterEquipDisplay = Instantiate(CharacterDisplayPrefab, setPosition, transform.rotation, canvas.transform);

        GameObject HeroGO = characterEquipDisplay.transform.GetChild(0).gameObject;
        GameObject ArcherGO = characterEquipDisplay.transform.GetChild(1).gameObject;
        GameObject MageGO = characterEquipDisplay.transform.GetChild(2).gameObject;


        GameObject[] options = { HeroGO, ArcherGO, MageGO };

        ChangeOptionsCharacters(options);
    }

    #endregion

    #region change options

    public void ChangeOptionsParty()
    {
        MenuManager.MenuOptions.Clear();

        MenuManager.MenuOptions.Add(1, member1);
        MenuManager.MenuOptions.Add(2, member3);
        MenuManager.MenuOptions.Add(3, member2);
        MenuManager.MenuOptions.Add(4, exitParty);

        MenuManager.minClamp = 1;
        MenuManager.maxClamp = 4;
    }

    public void ChangeOptionsMain()
    {
        MenuManager.MenuOptions.Clear();

        MenuManager.MenuOptions.Add(1, party);
        MenuManager.MenuOptions.Add(2, inventory);

        MenuManager.minClamp = 1;
        MenuManager.maxClamp = 2;
    }

    public void ChangeOptionsInventory()
    {
        MenuManager.MenuOptions.Clear();

        MenuManager.MenuOptions.Add(1, InventoryTitle);

        GameObject playerInventoryGO = GameObject.FindWithTag("Inventory");
        Inventory playerInventory = playerInventoryGO.GetComponent<Inventory>();

        int i = 2;
        for (; i < playerInventory.inventory.Count + 2; i++)
        {
            MenuManager.MenuOptions.Add(i, ItemDisplayGO[i - 2]);
        }
        MenuManager.MenuOptions.Add(i++, exitInventory);

        MenuManager.minClamp = 1;
        MenuManager.maxClamp = playerInventory.inventory.Count + 2;

        MenuManager.optionSelected = 1;
    }

    public void ChangeOptionsEquip(GameObject[] options)
    {
        MenuManager.MenuOptions.Clear();

        MenuManager.MenuOptions.Add(1, options[0]);
        MenuManager.MenuOptions.Add(2, options[1]);
        MenuManager.MenuOptions.Add(3, options[2]);

        MenuManager.minClamp = 1;
        MenuManager.maxClamp = 3;

        MenuManager.optionSelected = 1;

    }

    public void ChangeOptionsCharacters(GameObject[] options)
    {
        MenuManager.MenuOptions.Clear();

        MenuManager.MenuOptions.Add(1, options[0]);
        MenuManager.MenuOptions.Add(2, options[1]);
        MenuManager.MenuOptions.Add(3, options[2]);

        MenuManager.minClamp = 1;
        MenuManager.maxClamp = 3;

        MenuManager.optionSelected = 1;
    }

    public void ChangeOptionsCharSheet(GameObject option)
    {
        MenuManager.MenuOptions.Clear();

        MenuManager.MenuOptions.Add(1, option);

        MenuManager.minClamp = 1;
        MenuManager.maxClamp = 1;

        MenuManager.optionSelected = 1;
    }

    #endregion

    public void ResetAllPositions()
    {
        inventory.SetActive(false);
        party.SetActive(false);
        mainText.SetActive(false);

        Vector3 partyHudPosition = new Vector3(-1000, 16500, 1);

        partyHud.position = Vector3.Scale(partyHudPosition, canvas.transform.localScale);

        InventoryHUD.transform.position = Vector3.Scale(partyHudPosition, canvas.transform.localScale);

        ClearItemArray();

        MenuManager.optionSelected = 1;
    }
    #region clear stuff

    public void ClearItemArray()
    {
        try
        {
            foreach (GameObject item in ItemDisplayGO)
            {
                Destroy(item);
            }
        }
        catch { }
    }

    public void ClearItemOptions()
    {
        try
        {
            Destroy(itemOptionsDisplay);

        }
        catch { }
    }

    public void ClearCharSelect()
    {
        try
        {
            Destroy(characterEquipDisplay);
        }
        catch { }
    }

    public void ClearCharSheet()
    {
        try
        {
            Destroy(characterSheetDisplay);
        }
        catch { }
    }
    #endregion
}
