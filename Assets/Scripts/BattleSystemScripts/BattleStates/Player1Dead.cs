using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Dead : State
{
    public Player1Dead(BattleSystem battleSystem) : base(battleSystem)
    {
        
    }

    public override IEnumerator Start()
    {
        battleSystem.text.text = "Hero Dead";

        yield return new WaitForSeconds(5f);

        battleSystem.SetState(new PlayerTurn(battleSystem));
    }
}
