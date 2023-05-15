using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerInfo", menuName = "Persistence")]
public class PlayerInfo : ScriptableObject
{
    public Vector2 position;
    public Vector2 movePointPosition;
}
