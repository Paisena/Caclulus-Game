using System;
using UnityEngine;

public class QuestItemCreator : ItemCreator
{
    public override Item CreateItem(Item item)
    {
        Debug.Log("item created");
        return new QuestItem();
    }


}