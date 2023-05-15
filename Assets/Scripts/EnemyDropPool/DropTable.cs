using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DropTable : MonoBehaviour
{
    public List<Item> ItemDropTable = new List<Item>();
    public virtual List<Item> GetDropTable()
    {
        return ItemDropTable;
    }
}
