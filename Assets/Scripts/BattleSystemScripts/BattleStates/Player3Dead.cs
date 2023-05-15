using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3Dead : State
{
    public Player3Dead(BattleSystem battleSystem) : base(battleSystem)
    {
        
    }

    public override IEnumerator Start()
    {
        battleSystem.text.text = "Mage Dead";

        yield return new WaitForSeconds(5f);

        battleSystem.SetState(new PlayerTurn(battleSystem));
    }
}
