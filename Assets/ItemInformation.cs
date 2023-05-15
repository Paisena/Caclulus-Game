using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInformation : MonoBehaviour
{
    public Item itemType;

    public void SetItemType(Item type)
    {
        itemType = type;
    }
}
