using UnityEngine;

public class EquipableItemCreator : ItemCreator
{
    public override Item CreateItem(Item item)
    {
        //pull from drop table and then generate the item
        return item;
    }

}