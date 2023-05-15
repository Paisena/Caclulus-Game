
using UnityEngine;

public class UseableItemCreator : ItemCreator
{
    public override Item CreateItem(Item item)
    {
        Debug.Log("Usable Item Created");
        return new UseableItem();
    }

}