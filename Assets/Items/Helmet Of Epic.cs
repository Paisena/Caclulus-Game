using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class HelmetOfEpic : Armor
{
    private void Start() {
        
    }
    public HelmetOfEpic()
    {
        byte[] fileData;

        string filePath = "Assets/helmet.png";
        fileData = File.ReadAllBytes(filePath);
        Texture2D tex = new Texture2D(1,1);
        tex.LoadImage(fileData);
        itemImage = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f));
        itemImage.name = "Helmet of Epic";

        itemName = "Helmet Of Epic";
        itemRarity = Rarity.Epic;
        itemArmorType = Armor.ArmorType.Helm;
        itemDefense = 10;
        itemMana = 0;
    }
}
