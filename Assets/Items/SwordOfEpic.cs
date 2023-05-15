using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class SwordOfEpic : Weapon
{
    private void Start()
    {

    }
    public SwordOfEpic()
    {
        byte[] fileData;

        string filePath = "Assets/sword.png";
        fileData = File.ReadAllBytes(filePath);
        Texture2D tex = new Texture2D(1, 1);
        tex.LoadImage(fileData);
        itemImage = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f));
        itemImage.name = "Sword of Epic";

        itemName = "Sword Of Epic";
        itemRarity = Rarity.Epic;
        itemWeaponType = WeaponType.Sword;
        itemPhysicalDamage = 10;
        itemMagicDamage = 0;
        itemMana = 0;
    }
}
