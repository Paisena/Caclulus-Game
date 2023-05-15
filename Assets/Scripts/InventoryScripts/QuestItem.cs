using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestItem : Item
{
    string itemID;
    public QuestItem()
    {

    }

    public override void GetOptions()
    {
        Debug.Log("item factory works!");
    }
}
