using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue 
{
    // This script holds the name and dialogue of the actualy dialouge
    public string name;

    [TextArea(3, 10)]
    public string[] sentences;
}
