using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class Enemy1DropPool : DropTable
{
    //plan:
    // make new classes which inherit from the weapons or armor class and then you can manually add the values and then drag in that class into an array for the specific unit
    // so basically you make a like "cool sword" class and make it inherit from weapons class and then you change the values to create that item
    // also create a random value method which will be able to make items values within a range


    private void Start()
    {
        Item item1 = new SwordOfEpic();
        Item item2 = new HelmetOfEpic();
        ItemDropTable.Add(item1);
        ItemDropTable.Add(item2);
    }

    public override List<Item> GetDropTable()
    {
        return ItemDropTable;
    }
}
