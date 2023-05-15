using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//This will have the object which will be the inventory
public class Inventory : MonoBehaviour
{
    public QuestItemCreator questItemCreator = new QuestItemCreator();
    public EquipableItemCreator equipableItemCreator = new EquipableItemCreator();
    public UseableItemCreator useableItemCreator = new UseableItemCreator();

    private static Inventory inventoryInstance;

    public List<Item> inventory = new List<Item>();

    public int selectedItem; 

    private void Awake() {
        DontDestroyOnLoad(this);

        if(inventoryInstance == null)
        {
            inventoryInstance = this;
        }
        else
        {
            Object.Destroy(gameObject);
        }
    }

    private void Start() 
    {
        
    }
    public void CreateQuestItem(/*will probably put an id number to signify what item it is*/)
    {
        //Item item = questItemCreator.CreateItem();
        //item.GetOptions();
    }
    
    public void CreateEquipableItem(Item item)
    {
        Item newItem = equipableItemCreator.CreateItem(item);

        inventory.Add(newItem);
    }

    public void SetSelectedItem(int item)
    {
        selectedItem = item;
    }

    public void DeselectItem()
    {
        selectedItem = -1;
    }
}
